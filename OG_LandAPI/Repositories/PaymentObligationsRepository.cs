using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OG_LandAPI.Intefaces;
using OG_LandAPI.Models;

namespace OG_LandAPI.Repositories
{
    public class PaymentObligationsRepository : IPaymentObligationsRepository
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public PaymentObligationsRepository(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaymentObligations>> RetrieveAllPayments()
        {
            return await _context.PaymentObligations.ToListAsync();
        }

        public async Task<IEnumerable<PaymentObligations>> SearchAllTractsPaymentByLeaseId(string LeaseId)
        {
            return await _context.PaymentObligations.ToListAsync();
        }

        public async Task<IEnumerable<PaymentObligations>> SearchAllTractsPaymentByTractId(string TractId)
        {
            return await _context.PaymentObligations.ToListAsync();
        }
    }
}
