using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Lotto.Data;

namespace Lotto.TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            var lotto = new LottoData
                            {
                                LottoItems = new List<Data.Lotto>
                                                 {
                                                     new Data.Lotto
                                                         {
                                                             Id = 1,
                                                             Balls = new[] {1, 12, 22, 14, 32},
                                                             Country = Country.By,
                                                             Date = DateTime.Now.AddDays(-2),
                                                             Type = LottoType.a5of35,
                                                             WonAmount = 1000.2,
                                                             Profit = 134666.9
                                                         },
                                                     new Data.Lotto
                                                         {
                                                             Id = 2,
                                                             Balls = new[] {11, 2, 24, 35, 32},
                                                             Country = Country.Ru,
                                                             Date = DateTime.Now.AddDays(-1),
                                                             Type = LottoType.a5of35,
                                                             WonAmount = 1055.3,
                                                             Profit = 10000.9
                                                         },
                                                     new Data.Lotto
                                                         {
                                                             Id = 3,
                                                             Balls = new[] {12, 22, 4, 20, 22},
                                                             Country = Country.By,
                                                             Date = DateTime.Now.AddDays(-2),
                                                             Type = LottoType.a6of45,
                                                             WonAmount = 9990.2,
                                                             Profit = 134000.9
                                                         },
                                                     new Data.Lotto
                                                         {
                                                             Id = 4,
                                                             Balls = new[] {34, 25, 16, 43, 1},
                                                             Country = Country.Ru,
                                                             Date = DateTime.Now.AddDays(-1),
                                                             Type = LottoType.a6of45,
                                                             WonAmount = 1255.3,
                                                             Profit = 210000.5
                                                         },
                                                 }
            };
            
            var serializer = new XmlSerializer(typeof(LottoData));
            

            using (var writer = new StreamWriter(@"D:\temp\010\src\Lotto.Data\Lotto.xml"))
            {
                serializer.Serialize(writer, lotto);
            }
        }
    }
}
