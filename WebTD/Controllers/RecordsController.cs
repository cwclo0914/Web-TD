﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Login.Models;

namespace Login.Controllers
{
    public class RecordsController : ApiController
    {
        private LoginContext db = new LoginContext();

        // GET: api/Records
        public IQueryable<Record> GetRecords()
        {
            return db.Records;
        }

        // GET: api/Records/5
        [ResponseType(typeof(Record))]
        public async Task<IHttpActionResult> GetRecord(string id)
        {
            var records = await db.Records.Where(r => r.UserName == id).ToListAsync();
            if (records == null)
            {
                return NotFound();
            }

            return Ok(records);
        }

        // PUT: api/Records/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRecord(string id, Record record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != record.UserName)
            {
                return BadRequest();
            }

            db.Entry(record).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Records
        [ResponseType(typeof(Record))]
        public async Task<IHttpActionResult> PostRecord(Record record)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Records.Add(record);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RecordExists(record.UserName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = record.UserName }, record);
        }

        // DELETE: api/Records/5
        [ResponseType(typeof(Record))]
        public async Task<IHttpActionResult> DeleteRecord(string id)
        {
            var records = await db.Records.Where(r => r.UserName == id).ToListAsync();
            if (records == null)
            {
                return NotFound();
            }

            foreach (Record r in records)
            {
                db.Records.Remove(r);
            }
            await db.SaveChangesAsync();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RecordExists(string id)
        {
            return db.Records.Count(e => e.UserName == id) > 0;
        }
    }
}