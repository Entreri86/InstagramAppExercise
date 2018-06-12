using System;
using System.Collections.Generic;
using System.Text;

namespace InstagramAppExercise.Controller
{
    class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get
            {
                return $"http://lorempixel.com/200/200/people/{UserId}";
            }
        }

        public Activity()
        {

        }
    }
}
