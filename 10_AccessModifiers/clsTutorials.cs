using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AccessModifiers
{
    internal class clsTutorials
    {
        int TutorialID;
        string TutorialName;

        public void setTutorial(int pID,string pTutorialName)
        {
            this.TutorialID = pID;
            this.TutorialName = pTutorialName;
        }

        public string getTutorialName()
        {
            return this.TutorialName;
        }


    }
}
