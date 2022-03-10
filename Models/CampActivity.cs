using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MacsWebAssembly.Models
{
    public abstract class CampActivity : ICampActivity
    {
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        public string ActivityTitle { get; set; }
        public string ActivityDescription { get; set; }

        public CampActivity(DateTime startDate, DateTime endDate, string title, string description)
        {
            this.StartTime = startDate;
            this.EndTime = endDate;
            this.ActivityDescription = description;
            this.ActivityTitle = title;
        }

        public new string ToString() {
            var returnString = new StringBuilder();
            return returnString.Append(String.Format("%s ", ActivityTitle))
                .Append(String.Format("on %s ", StartTime.DayOfWeek))
                .Append(String.Format("the %s ", StartTime.Day))
                .Append(String.Format("of %s", StartTime.Month))
                .Append(String.Format("\nEnding:\t%s", EndTime.ToLongDateString()))
                .Append(String.Format("\nDescription:\n%s", ActivityDescription))
                .ToString();
        }


        public abstract List<CampActivity> GetActivityList();
        public abstract List<CampActivity> GetActivitiesFilteredByDate(DateTime startTime, DateTime endTime);
        public abstract void UpdateActivityList(List<CampActivity> originalList, List<CampActivity> updatedActivities);
        public abstract void UpdateActivity(CampActivity originalActivity, CampActivity updatedCampActivity);
        public abstract void DeleteActivity(CampActivity activity);
        public abstract void NewActivity(CampActivity activity);
    }
}