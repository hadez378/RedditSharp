﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace RedditSharp
{
    public class Subreddit
    {
        private Reddit Reddit { get; set; }

        public DateTime Created { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string HeaderImage { get; set; }
        public string HeaderTitle { get; set; }
        public string Id { get; set; }
        public bool NSFW { get; set; }
        public string PublicDescription { get; set; }
        public int Subscribers { get; set; }
        public int ActiveUsers { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        protected internal Subreddit(Reddit reddit, JObject json)
        {
            Reddit = reddit;
            var data = json["data"];
            Created = Reddit.UnixTimeStampToDateTime(data["created"].Value<double>());
            Description = data["description"].Value<string>();
            DisplayName = data["display_name"].Value<string>();
            HeaderImage = data["header_img"].Value<string>();
            HeaderTitle = data["header_title"].Value<string>();
            Id = data["id"].Value<string>();
            NSFW = data["over18"].Value<bool>();
            PublicDescription = data["public_description"].Value<string>();
            Subscribers = data["subscribers"].Value<int>();
            Title = data["title"].Value<string>();
            Url = data["url"].Value<string>();
        }

        public Post[] GetPosts(int page = 0)
        {
            return null;
        }
    }
}