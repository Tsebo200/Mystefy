using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mystefy.Data;
using Mystefy.Interfaces;
using Mystefy.Models;

namespace Mystefy.Services
{
    public class BatchIngredientsRepo : IBatchIngredientsRepository
    {
        private readonly MystefyDbContext _context;

        public BatchIngredientsRepo(MystefyDbContext context)
        {
            _context = context;
        }

        public async Task<BatchIngredients> CreateBatchIngredientAsync(BatchIngredients batchIngredient)
        {
            await _context.BatchIngredients.AddAsync(batchIngredient);
            await _context.SaveChangesAsync();
            return batchIngredient;
        }

        public async Task<BatchIngredients?> GetBatchIngredientAsync(int batchID, int ingredientsID)
        {
            return await _context.BatchIngredients
                .FirstOrDefaultAsync(bi => bi.BatchID == batchID && bi.IngredientsID == ingredientsID);
        }

        public async Task<IEnumerable<BatchIngredients>> GetAllBatchIngredientsAsync()
        {
            return await _context.BatchIngredients.ToListAsync();
        }

        public async Task<BatchIngredients?> UpdateBatchIngredientAsync(BatchIngredients batchIngredient)
        {
            _context.BatchIngredients.Update(batchIngredient);
            await _context.SaveChangesAsync();
            return batchIngredient;
        }

        public async Task<bool> DeleteBatchIngredientAsync(int batchID, int ingredientsID)
        {
            var batchIngredient = await GetBatchIngredientAsync(batchID, ingredientsID);
            if (batchIngredient == null)
                return false;
            _context.BatchIngredients.Remove(batchIngredient);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

