using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFixedDatebase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>() {
                                            new XSClubPromoter("Jon", "Jones", 8769087345),
                                            new XSClubPromoter("Jim", "Jones", 876543234),
                                            new OmniaClubPromoter("Jane", "Jones", 897657543)
                                            };


            Console.WriteLine("This shows how each promoter from promoters list promotes:");

            foreach (var promoter in promoters)
            {
                Console.WriteLine(promoter.MyBusinessCard);
                promoter.Promote();
                Console.WriteLine();
            }

            List<Writer> writers = new List<Writer>() {
                                            new BookWriter("Jon", "Jones"),
                                            new BookWriter("Jim", "Jones"),
                                            new BlogWriter("Jane", "Jones")
                                            };

            Console.WriteLine();
            Console.WriteLine("This shows how each writer from writers list writes:");

            foreach (var writer in writers)
            {
                Console.WriteLine(writer.AuthorBio);
                writer.Write();
                Console.WriteLine();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() {
                                            new XSClubPromoter("Jon", "Jones", 8769087345),
                                            new XSClubPromoter("Jim", "Jones", 876543234),
                                            };

            Console.WriteLine();
            Console.WriteLine("This shows how each bodybuilder works out:");

            foreach (var bodyBuilder in bodyBuilders)
            {
                bodyBuilder.WorkOut();
            }

            List<IVlogger> vloggers = new List<IVlogger>() {
                                            new XSClubPromoter("Jon", "Jones", 8769087345),
                                            new BookWriter("Jane", "Watts")
                                            };

            Console.WriteLine();
            Console.WriteLine("This shows how each vlogger vlogs:");

            foreach (var vlogger in vloggers)
            {
                vlogger.Vlog();
            }

            Console.ReadKey();
        }
    }
}
