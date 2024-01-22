using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Lotto.Data
{
    public class LottoDataProvider
    {
        private readonly string _dataPath = ConfigurationManager.AppSettings["dataFilePath"];
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof (LottoData));

        public LottoData GetAll()
        {
            using (var reader = new StreamReader(_dataPath))
            {
                return (LottoData) _serializer.Deserialize(reader);
            }
        }

        public void Save(int id, int[] balls, Country country, DateTime date, LottoType type, double wonAmount,
                         double profit)
        {
            var lotto = new Lotto
                            {
                                Id = id,
                                Balls = balls,
                                Date = date,
                                Country = country,
                                Type = type,
                                WonAmount = wonAmount,
                                Profit = profit
                            };

            Save(lotto);
        }

        public void Save(Lotto lotto)
        {
            LottoData all = GetAll();

            if (lotto.Id <= 0)
            {
                lotto.Id = all.LottoItems.Max(l => l.Id) + 1;
            }
            else
            {
                all.LottoItems.Remove(all.LottoItems.Where(l => l.Id == lotto.Id).Single());
            }

            all.LottoItems.Add(lotto);

            using (var writer = new StreamWriter(_dataPath))
            {
                _serializer.Serialize(writer, all);
            }
        }

        public void Delete(int id)
        {
            LottoData all = GetAll();
            all.LottoItems.Remove(all.LottoItems.Where(l => l.Id == id).Single());

            using (var writer = new StreamWriter(_dataPath))
            {
                _serializer.Serialize(writer, all);
            }
        }
    }
}