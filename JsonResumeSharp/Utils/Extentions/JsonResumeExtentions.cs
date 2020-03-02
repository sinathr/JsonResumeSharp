using QuickType;
using System;
using System.Collections.Generic;
using System.Text;
using JsonResumeSharp.Utils;

namespace JsonResumeSharp.Utils.Extentions
{
    public static class JsonResumeExtentions
    {

        public static JsonResume AddWork(this JsonResume jsonResume,Work work)
        { 

            Utilities.AddItemToArray(jsonResume.Work, work);
            return jsonResume;
        }

        public static JsonResume AddVolunteer(this JsonResume jsonResume,Volunteer volunteer)
        {
            Utilities.AddItemToArray(jsonResume.Volunteer, volunteer);
            return jsonResume;




        }

        public static JsonResume AddEducation(this JsonResume jsonResume, Education education)
        {
            Utilities.AddItemToArray(jsonResume.Education, education);
            return jsonResume;
        }


        public static JsonResume AddSkill(this JsonResume jsonResume, Skill skill)
        {
            Utilities.AddItemToArray(jsonResume.Skills, skill);
            return jsonResume;
        }


        public static JsonResume AddLanguage(this JsonResume jsonResume, Language language)
        {
            Utilities.AddItemToArray(jsonResume.Languages, language);
            return jsonResume;
        }

        public static JsonResume AddAward(this JsonResume jsonResume, Award work)
        {
            Utilities.AddItemToArray(jsonResume.Awards, work);
            return jsonResume;
        }

        public static JsonResume AddInterest(this JsonResume jsonResume,Interest interest)
        {
            Utilities.AddItemToArray(jsonResume.Interests, interest);
            return jsonResume;
        }

        public static JsonResume AddPublication(this JsonResume jsonResume, Publication publication)
        {
            Utilities.AddItemToArray(jsonResume.Publications, publication);
            return jsonResume;
        }


    }
}
