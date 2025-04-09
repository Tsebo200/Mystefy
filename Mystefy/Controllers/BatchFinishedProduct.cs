using System;
using Microsoft.AspNetCore.Mvc;
using Mystefy.DTOs;
using Mystefy.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mystefy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BatchFinishedProductController : ControllerBase
    {
        private readonly IBatchFinishedProductService _service;

        public BatchFinishedProductController(IBatchFinishedProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BatchFinishedProductDTO>>> GetAll()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{batchId:int}/{productId:int}")]
        public async Task<ActionResult<BatchFinishedProductDTO>> Get(int batchId, int productId)
        {
            var product = await _service.GetByIdAsync(batchId, productId);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] BatchFinishedProductDTO dto)
        {
            var success = await _service.CreateAsync(dto);
            if (!success) return BadRequest("Unable to create record.");
            return Ok();
        }

        [HttpPut("{batchId:int}/{productId:int}")]
        public async Task<ActionResult> Update(int batchId, int productId, [FromBody] BatchFinishedProductDTO dto)
        {
            if (batchId != dto.BatchID || productId != dto.ProductID)
                return BadRequest("Mismatched IDs.");

            var success = await _service.UpdateAsync(dto);
            if (!success) return NotFound();
            return Ok();
        }

        [HttpDelete("{batchId:int}/{productId:int}")]
        public async Task<ActionResult> Delete(int batchId, int productId)
        {
            var success = await _service.DeleteAsync(batchId, productId);
            if (!success) return NotFound();
            return Ok();
        }
    }
}

