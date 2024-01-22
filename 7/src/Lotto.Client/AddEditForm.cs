using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lotto.Data;

namespace Lotto.Client
{
    public partial class AddEditForm : Form
    {
        private readonly LottoData _lotto = new LottoData();

        public AddEditForm()
        {
            InitializeComponent();
        }

        public void InitLotto()
        {
            var lotto = _lotto.GetAll().LottoItems.Where(l => l.Id == Id).Single();

            tbBalls.Text = GetStringBalls(lotto);
            tbProfit.Text = lotto.Profit.ToString();
            tbWon.Text = lotto.WonAmount.ToString();
            date.Value = lotto.Date.Date;
            ddlCountry.SelectedItem = lotto.Country.ToString();
            ddlType.SelectedItem = lotto.Type.ToString();
        }

        public int Id { get; set; }

        private void BtnFindClick(object sender, EventArgs e)
        {
            var lotto = new Data.Lotto
                            {
                                Id = Id,
                                Balls = GetIntBalls(),
                                Country = ddlCountry.Text == "By" ? Country.By : Country.Ru,
                                Date = date.Value,
                                Profit = double.Parse(tbProfit.Text),
                                Type = ddlType.Text == "a5of35" ? LottoType.a5of35 : LottoType.a6of45,
                                WonAmount = double.Parse(tbWon.Text)
                            };
            _lotto.Save(lotto);
            DialogResult = DialogResult.OK;
            Close();
        }

        private int[] GetIntBalls()
        {
            var result = new List<int>();

            var balls = tbBalls.Text.Split(' ').Where(b => !string.IsNullOrEmpty(b));
            balls.ToList().ForEach(b => result.Add(int.Parse(b)));

            return result.ToArray();
        }

        private string GetStringBalls(Data.Lotto lotto)
        {
            var builder = new StringBuilder();
            lotto.Balls.ToList().ForEach(b => builder.Append(b + " "));

            return builder.ToString();
        }
    }
}