using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //conferindo se tem registro nas tabelas
            if (_context.Department.Any() ||
               _context.Seller.Any() ||
               _context.SalesRecord.Any())
            {
                return; // BD já foi populado
            }

            //criando os registros que serão inseridos na tabela de Department
            Department computersDepartment = new Department("Computers");
            Department eletronicsDepartment = new Department("Eletronics");
            Department fashionDepartment = new Department("Fashion");
            Department booksDepartment = new Department("Books");

            //criando os registros que serão inseridos na tabela de Saller
            Seller SellerBob = new Seller("Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, computersDepartment);
            Seller SellerMaria = new Seller("Maria Greem", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, eletronicsDepartment);
            Seller SellerAlex = new Seller("Alex Grey", "Alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, computersDepartment);
            Seller SellerMartha = new Seller("Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, booksDepartment);
            Seller SellerDonald = new Seller("Donald Blue", "Donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, fashionDepartment);
            Seller SellerAlexPink = new Seller("Alex Pink", "alexPink@gmail.com", new DateTime(1997, 3, 4), 3000.0, eletronicsDepartment);

            //criando os registros que serão inseridos na tabela de SalesRecord
            SalesRecord r1 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, SellerBob);
            SalesRecord r2 = new SalesRecord(new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, SellerDonald);
            SalesRecord r3 = new SalesRecord(new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, SellerMartha);
            SalesRecord r4 = new SalesRecord(new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, SellerBob);
            SalesRecord r5 = new SalesRecord(new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, SellerAlex);
            SalesRecord r6 = new SalesRecord(new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, SellerBob);
            SalesRecord r7 = new SalesRecord(new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, SellerMaria);
            SalesRecord r8 = new SalesRecord(new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, SellerMartha);
            SalesRecord r9 = new SalesRecord(new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, SellerAlexPink);
            SalesRecord r10 = new SalesRecord(new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, SellerAlexPink);
            SalesRecord r11 = new SalesRecord(new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, SellerMaria);
            SalesRecord r12 = new SalesRecord(new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, SellerAlex);
            SalesRecord r13 = new SalesRecord(new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, SellerMartha);
            SalesRecord r14 = new SalesRecord(new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, SellerDonald);
            SalesRecord r15 = new SalesRecord(new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, SellerBob);
            SalesRecord r16 = new SalesRecord(new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, SellerMartha);
            SalesRecord r17 = new SalesRecord(new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, SellerBob);
            SalesRecord r18 = new SalesRecord(new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, SellerAlex);
            SalesRecord r19 = new SalesRecord(new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, SellerDonald);
            SalesRecord r20 = new SalesRecord(new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, SellerAlexPink);
            SalesRecord r21 = new SalesRecord(new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, SellerMaria);
            SalesRecord r22 = new SalesRecord(new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, SellerMartha);
            SalesRecord r23 = new SalesRecord(new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, SellerMaria);
            SalesRecord r24 = new SalesRecord(new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, SellerDonald);
            SalesRecord r25 = new SalesRecord(new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, SellerAlex);
            SalesRecord r26 = new SalesRecord(new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, SellerMartha);
            SalesRecord r27 = new SalesRecord(new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, SellerBob);
            SalesRecord r28 = new SalesRecord(new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, SellerAlex);
            SalesRecord r29 = new SalesRecord(new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, SellerDonald);
            SalesRecord r30 = new SalesRecord(new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, SellerMaria);

            //inserindo os registros na tabela Department
            _context.Department.AddRange(computersDepartment, eletronicsDepartment, fashionDepartment, booksDepartment);

            //inserindo os registros na tabela Seller
            _context.Seller.AddRange(SellerBob, SellerMaria, SellerAlex, SellerMartha, SellerDonald, SellerAlexPink);

            //inserindo os registros na tabela SalesRecord
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                                          r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                                          r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            //Salvando as alterações no banco
            _context.SaveChanges();
        }
    }
}
