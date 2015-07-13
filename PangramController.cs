using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Newtonsoft.Json;

using Pangrams.Models;

namespace Pangrams.Controllers
{

    public class PangramController : ApiController
    {
        private static List<string> sentences = new List<string>();

        public object Post([FromBody] PangramModel sentence)
        {
            var isPangram = false;

            if (sentence != null && (!string.IsNullOrEmpty(sentence.Sentence)))
            {
                sentences.Add(sentence.Sentence);
                isPangram = sentence.Sentence.ToString().ToLower()
                .Where(ch => Char.IsLetter(ch))
                .GroupBy(ch => ch)
                .Count() == 26;
            }

            var model = new IsPangramModel { IsPangram = isPangram };

            return model;
        }

        public object Get(int limit)
        {
            var model = new SentencesModel();
            model.Pangrams = sentences.Count <= limit ? sentences : sentences.Take(limit).ToList();
            return model;
        }
    }
}
