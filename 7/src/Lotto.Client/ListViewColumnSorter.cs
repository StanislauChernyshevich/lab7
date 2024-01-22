using System.Collections;
using System.Windows.Forms;

namespace Lotto.Client
{
    public class ListViewColumnSorter : IComparer
    {
        private readonly CaseInsensitiveComparer _objectCompare;
        private int _columnToSort;
        private SortOrder _orderOfSort;

        public ListViewColumnSorter()
        {
            _columnToSort = 0;

            _orderOfSort = SortOrder.None;
            _objectCompare = new CaseInsensitiveComparer();
        }

        public int SortColumn
        {
            set { _columnToSort = value; }
            get { return _columnToSort; }
        }

        public SortOrder Order
        {
            set { _orderOfSort = value; }
            get { return _orderOfSort; }
        }

        #region IComparer Members

        public int Compare(object x, object y)
        {
            var listviewX = (ListViewItem)x;
            var listviewY = (ListViewItem)y;

            int compareResult = _objectCompare.Compare(listviewX.SubItems[_columnToSort].Text,
                                                       listviewY.SubItems[_columnToSort].Text);

            if (_orderOfSort == SortOrder.Ascending)
            {
                return compareResult;
            }
            if (_orderOfSort == SortOrder.Descending)
            {
                return (-compareResult);
            }

            return 0;
        }

        #endregion
    }
}