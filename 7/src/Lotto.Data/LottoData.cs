using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lotto.Data
{
    [Serializable]
    public class LottoData : MarshalByRefObject
    {
        private readonly LottoDataProvider _provider = new LottoDataProvider();

        [XmlArrayItem("Lotto")]
        public List<Lotto> LottoItems { get; set; }

        public LottoData GetAll()
        {
            return _provider.GetAll();
        }

        public void Save(int id, int[] balls, Country country, DateTime date, LottoType type,
                           double wonAmount, double profit)
        {
            _provider.Save(id, balls, country, date, type, wonAmount, profit);
        }

        public void Save(Lotto lotto)
        {
            _provider.Save(lotto);
        }

        public void Delete(int id)
        {
            _provider.Delete(id);
        }
    }

    [Serializable]
    public class Lotto
    {
        [XmlAttribute]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Country Country { get; set; }

        public LottoType Type { get; set; }

        public double WonAmount { get; set; }
        public double Profit { get; set; }

        [XmlArray("Balls")]
        [XmlArrayItem("Ball")]
        public int[] Balls { get; set; }
    }

    public enum Country
    {
        By,
        Ru
    }

    public enum LottoType
    {
        a5of35,
        a6of45
    }
}