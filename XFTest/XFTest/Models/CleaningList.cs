using System.Collections.Generic;
using Newtonsoft.Json;

namespace XFTest.Models
{

    public class CleaningList
    {
        private string userName;
        private string btnColor;
        private string expectedTime1;

        [JsonProperty("visitId", NullValueHandling = NullValueHandling.Ignore)]
        public string visitId { get; set; }

        [JsonProperty("homeBobEmployeeId", NullValueHandling = NullValueHandling.Ignore)]
        public string homeBobEmployeeId { get; set; }

        [JsonProperty("houseOwnerId", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerId { get; set; }

        [JsonProperty("isBlocked", NullValueHandling = NullValueHandling.Ignore)]
        public bool isBlocked { get; set; }

        [JsonProperty("startTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public string startTimeUtc { get; set; }

        [JsonProperty("endTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public string endTimeUtc { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string title { get; set; }

        [JsonProperty("isReviewed", NullValueHandling = NullValueHandling.Ignore)]
        public bool isReviewed { get; set; }

        [JsonProperty("isFirstVisit", NullValueHandling = NullValueHandling.Ignore)]
        public bool isFirstVisit { get; set; }

        [JsonProperty("isManual", NullValueHandling = NullValueHandling.Ignore)]
        public bool isManual { get; set; }

        [JsonProperty("visitTimeUsed", NullValueHandling = NullValueHandling.Ignore)]
        public string visitTimeUsed { get; set; }

        [JsonProperty("rememberToday", NullValueHandling = NullValueHandling.Ignore)]
        public string rememberToday { get; set; }

        [JsonProperty("houseOwnerFirstName", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerFirstName { get; set; }

        [JsonProperty("houseOwnerLastName", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerLastName { get; set; }

        [JsonProperty("houseOwnerMobilePhone", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerMobilePhone { get; set; }

        [JsonProperty("houseOwnerAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerAddress { get; set; }

        [JsonProperty("houseOwnerZip", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerZip { get; set; }

        [JsonProperty("houseOwnerCity", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerCity { get; set; }

        [JsonProperty("houseOwnerLatitude", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerLatitude { get; set; }

        [JsonProperty("houseOwnerLongitude", NullValueHandling = NullValueHandling.Ignore)]
        public string houseOwnerLongitude { get; set; }

        [JsonProperty("isSubscriber", NullValueHandling = NullValueHandling.Ignore)]
        public bool isSubscriber { get; set; }

        [JsonProperty("rememberAlways", NullValueHandling = NullValueHandling.Ignore)]
        public string rememberAlways { get; set; }

        [JsonProperty("professional", NullValueHandling = NullValueHandling.Ignore)]
        public string professional { get; set; }

        [JsonProperty("visitState", NullValueHandling = NullValueHandling.Ignore)]
        public string visitState { get; set; }

        [JsonProperty("stateOrder", NullValueHandling = NullValueHandling.Ignore)]
        public string stateOrder { get; set; }

        [JsonProperty("expectedTime", NullValueHandling = NullValueHandling.Ignore)]
        public string expectedTime
        {
            get => expectedTime1;
            set
            {
                try
                {
                    string[] words = value.Split('/');
                    expectedTime1 = words[0] + "-" + words[1];
                }
                catch (System.Exception ex)
                {
                    expectedTime1 = value;

                }

            }
        }

        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskData> tasks { get; set; }


        public string UserName { get { return houseOwnerFirstName + " " + houseOwnerLastName; } }
        public string BtnColor { get { if (visitState == "ToDo") return "#4E77D6"; else if (visitState == "InProgress") return "#F5C709"; else if (visitState == "Done") return "#25A87B"; else return "#EF6565"; } }
        public string Address { get { return houseOwnerAddress + " " + houseOwnerZip + " " + houseOwnerCity; } }
        public string Time
        {

            get
            {
                try
                {
                    if (!string.IsNullOrEmpty(startTimeUtc) && !string.IsNullOrEmpty(expectedTime))
                    {
                        return startTimeUtc.Substring(11, 5) + "/ " + expectedTime;
                    }
                    else
                    {
                        return startTimeUtc.Substring(11, 5);

                    }
                }
                catch (System.Exception ex)
                {
                    return "";

                }

            }
        }
        public string MyTitle { get; set; }
        public string SumTime { get; set; }
        public string Distance { get; set; }

        public string workDate
        {

            get
            {
                try
                {
                    if (!string.IsNullOrEmpty(startTimeUtc))
                    {
                        return startTimeUtc.Substring(0, 10);
                    }
                    else
                    {
                        return "";

                    }
                }
                catch (System.Exception ex)
                {
                    return "";

                }

            }
        }


    }



    public class TaskData
    {
        [JsonProperty("taskId", NullValueHandling = NullValueHandling.Ignore)]
        public string taskId { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string title { get; set; }

        [JsonProperty("isTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public bool isTemplate { get; set; }

        [JsonProperty("timesInMinutes", NullValueHandling = NullValueHandling.Ignore)]
        public string timesInMinutes { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string price { get; set; }

        [JsonProperty("paymentTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public string paymentTypeId { get; set; }

        [JsonProperty("createDateUtc", NullValueHandling = NullValueHandling.Ignore)]
        public string createDateUtc { get; set; }

        [JsonProperty("lastUpdateDateUtc", NullValueHandling = NullValueHandling.Ignore)]
        public string lastUpdateDateUtc { get; set; }

        [JsonProperty("paymentTypes", NullValueHandling = NullValueHandling.Ignore)]
        public string paymentTypes { get; set; }
    }

    public class RequestList
    {
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool success { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string message { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<CleaningList> data { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string code { get; set; }

    }
}
