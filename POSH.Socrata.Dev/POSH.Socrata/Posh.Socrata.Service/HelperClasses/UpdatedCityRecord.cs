﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Posh.Socrata.Service.HelperClasses
{
    public class UpdatedCityRecord : TableEntity
    {
        public UpdatedCityRecord(string CityName, int RowId)
        {
            this.PartitionKey = CityName;
            this.RowKey = RowId.ToString();
        }
        public UpdatedCityRecord() { }
        public int RowId { get; set; }
        public string UUID { get; set; }
        public string CityName { get; set; }
        public string APIURL { get; set; }
        public int Count { get; set; }
        public int UpdatedCount { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ExpiryDate { get; set; }
       
        public string DatasetName { get; set; }
    }
}