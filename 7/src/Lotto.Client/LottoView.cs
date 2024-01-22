using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lotto.Data;

namespace Lotto.Client
{
    public partial class LottoView : Form
    {
        private readonly ListViewColumnSorter _lvwColumnSorter;
        private readonly LottoData _lotto = new LottoData();

        public LottoView()
        {
            InitializeComponent();

            _lvwColumnSorter = new ListViewColumnSorter();
            lwData.ListViewItemSorter = _lvwColumnSorter;

            lwData.ItemActivate += lwData_ItemActivate;
            lwData.ItemCheck += lwData_ItemActivate;
            
            List<Data.Lotto> lottoItems = GetAll().LottoItems;
            BindItems(lottoItems);
        }

        private LottoData GetAll()
        {
            return _lotto.GetAll();
        }

        private void BindItems(IEnumerable<Data.Lotto> lottoItems)
        {
            lwData.Items.Clear();

            foreach (Data.Lotto item in lottoItems)
            {
                lwData.Items.Add(CreateViewItem(item));
            }
        }

        private static ListViewItem CreateViewItem(Data.Lotto lotto)
        {
            var listItem =
                new ListViewItem(new[]
                                     {
                                         lotto.Id.ToString(), lotto.Date.ToShortDateString(), lotto.Type.ToString(),
                                         lotto.Country.ToString(), GetBalls(lotto), lotto.WonAmount.ToString(),
                                         lotto.Profit.ToString()
                                     });
            return listItem;
        }

        private void lwData_ItemActivate(object sender, EventArgs e)
        {
            var lw = (ListView) sender;
            statusStrip.Items[0].Text = "Selected item id is " + lw.SelectedItems[0].Text;
        }

        private static string GetBalls(Data.Lotto lotto)
        {
            var builder = new StringBuilder();
            lotto.Balls.ToList().ForEach(b => builder.Append(b + " "));

            return builder.ToString();
        }

        private void LwDataColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == _lvwColumnSorter.SortColumn)
            {
                _lvwColumnSorter.Order = 
                    _lvwColumnSorter.Order == SortOrder.Ascending 
                    ? SortOrder.Descending 
                    : SortOrder.Ascending;
            }
            else
            {
                _lvwColumnSorter.SortColumn = e.Column;
                _lvwColumnSorter.Order = SortOrder.Ascending;
            }

            lwData.Sort();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lwData.Items.Clear();
            if(e.Node.Text == "By")
            {
                BindItems(GetAll().LottoItems.Where(i => i.Country == Data.Country.By));
            }
            else if (e.Node.Text == "Ru")
            {
                BindItems(GetAll().LottoItems.Where(i => i.Country == Data.Country.Ru));
            }
            else
            {
                BindItems(GetAll().LottoItems);
            }
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "a5of35")
            {
                BindItems(GetAll().LottoItems.Where(i => i.Type == LottoType.a5of35));
            }
            else if (e.Node.Text == "a6of45")
            {
                BindItems(GetAll().LottoItems.Where(i => i.Type == LottoType.a6of45));
            }
            else
            {
                BindItems(GetAll().LottoItems);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var items = GetAll().LottoItems;

            if (!string.IsNullOrEmpty(tdId.Text))
                items = items.Where(i => i.Id == int.Parse(tdId.Text)).ToList();

            if (dateStart.Checked)
                items = items.Where(i => i.Date.Date >= dateStart.Value.Date).ToList();

            if (dateEnd.Checked)
                items = items.Where(i => i.Date.Date <= dateEnd.Value.Date).ToList();

            BindItems(items);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowEdit(0, false);
        }

        private void ShowEdit(int id, bool initLottoData)
        {
            var form = new AddEditForm {Id = id};
            if (initLottoData)
                form.InitLotto();
            if(form.ShowDialog() == DialogResult.OK)
                BindItems(GetAll().LottoItems);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lwData.SelectedItems.Count > 0)
            {
                var selected = lwData.SelectedItems[0];
                ShowEdit(int.Parse(selected.Text), true);
            }
            else
            {
                MessageBox.Show("Please select item to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lwData.SelectedItems.Count > 0)
            {
                var selected = lwData.SelectedItems[0];
                _lotto.Delete(int.Parse(selected.Text));
                BindItems(GetAll().LottoItems);
            }
            else
            {
                MessageBox.Show("Please select item to delete");
            }
        }      
    }
}