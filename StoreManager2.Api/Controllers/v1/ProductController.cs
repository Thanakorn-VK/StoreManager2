﻿using StoreManager2.API.Controllers;
using StoreManager2.Application.Features.Products.Commands.Create;
using StoreManager2.Application.Features.Products.Commands.Delete;
using StoreManager2.Application.Features.Products.Commands.Update;
using StoreManager2.Application.Features.Products.Queries.GetAllPaged;
using StoreManager2.Application.Features.Products.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace StoreManager2.Api.Controllers.v1
{
    public class ProductController : BaseApiController<ProductController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var products = await _mediator.Send(new GetAllProductsQuery(pageNumber, pageSize));
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery() { Id = id });
            return Ok(product);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateProductCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteProductCommand { Id = id }));
        }
    }
}