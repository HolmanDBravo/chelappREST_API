﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//Add These
using chelappREST_API.Models;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;


namespace chelappREST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesPermissionsController : ControllerBase
    {

        private readonly IDocumentClient _documentClient;
        readonly String databaseId;
        readonly String collectionId;
        public IConfiguration Configuration { get; }

        public RolesPermissionsController(IDocumentClient documentClient, IConfiguration configuration)
        {
            _documentClient = documentClient;
            Configuration = configuration;

            databaseId = Configuration["DatabaseId"];
            collectionId = "roles_permissions";

            BuildCollection().Wait();
        }

        private async Task BuildCollection()
        {
            await _documentClient.CreateDatabaseIfNotExistsAsync(new Database { Id = databaseId });
            await _documentClient.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri(databaseId),
            new DocumentCollection { Id = collectionId });
        }

        [HttpGet]
        public IQueryable<RolesPermissionsViewModel> Get()
        {
            return _documentClient.CreateDocumentQuery<RolesPermissionsViewModel>(UriFactory.CreateDocumentCollectionUri(databaseId, collectionId),
                new FeedOptions { MaxItemCount = 20 });
        }

        [HttpGet("{id}")]
        public IQueryable<RolesPermissionsViewModel> Get(int id)
        {
            return _documentClient.CreateDocumentQuery<RolesPermissionsViewModel>(UriFactory.CreateDocumentCollectionUri(databaseId, collectionId),
                new FeedOptions { EnableCrossPartitionQuery = true, MaxItemCount = 1 }).Where((i) => i.IdRol == id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RolesPermissionsViewModel item)
        {
            var response = await _documentClient.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseId, collectionId), item);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] RolesPermissionsViewModel item)
        {
            await _documentClient.ReplaceDocumentAsync(UriFactory.CreateDocumentUri(databaseId, collectionId, id),
                item);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _documentClient.DeleteDocumentAsync(UriFactory.CreateDocumentUri(databaseId, collectionId, id));
            return Ok();
        }


    }
}