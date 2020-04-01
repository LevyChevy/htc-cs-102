using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieListInheritance
{
     public class AnimationMovie : Movie
    {
        public string AnimationStudio;
        public string AnimationType;

        public AnimationMovie()
        {

        }
        public AnimationMovie(string animationstudio, string animationtype, string title, int releaseyear)
        {
            AnimationStudio = animationstudio;
            AnimationType = animationtype;
            Title = title;
            ReleaseYear = releaseyear;
        }
    }
}
