using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace ResponseFormat
{
    [System.Serializable]
    public class WelcomeResponse
    {
        public string message;

        public static WelcomeResponse CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<WelcomeResponse>(jsonString);

        }

    }

    [System.Serializable]
    public class HeaderResponse
    {
        public bool success;
        public string message;
        public static HeaderResponse CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<HeaderResponse>(jsonString);
        }
    }

    [System.Serializable]
    public class PostDateOfBirthFormat
    {
        public int year;
        public int month;
        public int day;
    }

    [System.Serializable]
    public class PostDataFormat
    {
        public string username;
        public string email;
        public PostDateOfBirthFormat dateOfBirth;

    }

    [System.Serializable]
    public class PostResponse
    {
        public bool success;
        public PostDataFormat data;
        public static PostResponse CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<PostResponse>(jsonString);
        }
    }


}
