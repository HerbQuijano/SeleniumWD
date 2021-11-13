using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endofcouse
{
    class ComplicatedPage : BasePage
    {
        private SectionOfButtons buttonsSection;
        private SectionOfSocialMedia socialMediaSection;
        private SectionOfRandomStuff randomStuffSection;


        public SectionOfButtons ButtonsSection { get => buttonsSection; set => buttonsSection = value; }

        public override string PageName { get => "Complicated Page"; }

        public SectionOfSocialMedia SocialMediaSection { get => socialMediaSection; set => socialMediaSection = value; }
        public SectionOfRandomStuff RandomStuffSection { get => randomStuffSection; set => randomStuffSection = value; }

       
    }
}
