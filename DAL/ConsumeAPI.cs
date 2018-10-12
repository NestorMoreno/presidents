﻿using System;
using System.Net;
using System.Net.Http;
using DTO;
using System.Collections.Generic;
using System.IO;
using System.Configuration;

namespace DAL
{
    public class ConsumeAPI
    {
        List<President> result = new List<President>();
        private string endpoint = string.Empty;

        public ConsumeAPI()
        {
            endpoint = "http://www.mocky.io/v2/5bc0f9a53200007c0021abc5";
        }

        public List<President> GetPresidents()
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(endpoint);
                using (var res = req.GetResponse()) { 
                    using (var reader = new StreamReader(res.GetResponseStream()))
                    {
                        result = (List<President>)Newtonsoft.Json.JsonConvert.DeserializeObject(reader.ReadLine(), typeof(List<President>));
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL. GetPresidents. Error:" + ex);
            }
        }
    }
}
