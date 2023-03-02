using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorrphism
{
    internal class clsTutorials
    {
        protected int TutorialID;
        protected string TutorialName;
        protected string TutorialDescription;

        public void setTutorial(int pID,string pTutorialName)
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
        }
        public void setTutorial(string pTutorialName)
        {
            TutorialName = pTutorialName;
        }
        public void setTutorial(int pID, string pTutorialName,string pDesc)
        {
            TutorialID = pID;
            TutorialName = pTutorialName;
            TutorialDescription = pDesc;
        }


        public string getTutorialName()
        {
            return TutorialName + " " + TutorialID ;
        }


    }
}
