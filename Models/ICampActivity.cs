namespace MacsWebAssembly.Models; 

public interface ICampActivity {
    List<CampActivity>GetActivityList();
    List<CampActivity> GetActivitiesFilteredByDate(DateTime startTime, DateTime endTime);
    void UpdateActivityList(List<CampActivity> originalList, List<CampActivity> updatedActivities);
    void UpdateActivity(CampActivity originalActivity, CampActivity updatedCampActivity);
    void DeleteActivity(CampActivity activity);
    void NewActivity(CampActivity activity);
}
