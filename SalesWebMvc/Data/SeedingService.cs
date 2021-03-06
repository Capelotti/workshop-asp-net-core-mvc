﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been populated
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bobbrown@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(1, "Maria Green", "greenm@gmail.com", new DateTime(1979, 12, 31), 2500.0, d2);
            Seller s3 = new Seller(1, "Alex Gray", "alex@gmail.com", new DateTime(1988, 1, 15), 1500.0, d3);
            Seller s4 = new Seller(1, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3100.0, d4);
            Seller s5 = new Seller(1, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 2000.0, d1);
            Seller s6 = new Seller(1, "Aex Pink", "pink@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(1, new DateTime(2018, 09, 22), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(1, new DateTime(2018, 09, 12), 600.0, SaleStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(1, new DateTime(2018, 10, 21), 50.5, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(1, new DateTime(2018, 09, 14), 500.0, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(1, new DateTime(2018, 09, 7), 8000.0, SaleStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(1, new DateTime(2018, 09, 25), 800.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(1, new DateTime(2018, 09, 2), 20.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(1, new DateTime(2018, 09, 28), 4500.0, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(1, new DateTime(2018, 10, 28), 3300.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(1, new DateTime(2018, 10, 30), 12000.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(1, new DateTime(2018, 10, 6), 22000.0, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(1, new DateTime(2018, 10, 10), 7777.0, SaleStatus.Billed, s5);
            SalesRecord r14 = new SalesRecord(1, new DateTime(2018, 10, 18), 1170.0, SaleStatus.Billed, s4);
            SalesRecord r15 = new SalesRecord(1, new DateTime(2018, 10, 23), 140.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(1, new DateTime(2018, 09, 15), 11500.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(1, new DateTime(2018, 10, 4), 1600.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(1, new DateTime(2018, 09, 25), 15770.0, SaleStatus.Billed, s2);
            SalesRecord r19 = new SalesRecord(1, new DateTime(2018, 10, 2), 11000.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19);
            _context.SaveChanges();
        }
    }
}
