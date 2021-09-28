using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ResponseFormat;

public class ClickListener : MonoBehaviour
{
    const string requestURL = "http://localhost:8080/check-post";
 

    public void ButtonClicked()
    {
        WWW test = new WWW(requestURL,returnPostBody(),returnWithHeaders());
        StartCoroutine(SendPostRequest(test));
        
        
    }
    private IEnumerator SendPostRequest(WWW req)
    {
        yield return req;
        string result = req.text;
        PostResponse p = PostResponse.CreateFromJSON(result);
        print(p.data.dateOfBirth.day);


    }

    private byte[] returnPostBody()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", "ningombam.singh@learner.manipal.edu");


        return form.data;
    }

    private Dictionary<string,string> returnWithHeaders()
    {
        WWWForm form = new WWWForm();
        Dictionary<string, string> d = form.headers;
        d.Add("test-header", "header received boy");

        return d;
    }

    private IEnumerator fetchHeaderRequest(WWW req)
    {
        yield return req;
        string result = req.text;
        HeaderResponse temp = HeaderResponse.CreateFromJSON(result);
        print(temp.success);
        print(temp.message);
    }
    private IEnumerator fetchWelcomeRequest(WWW req)
    {
        yield return req;
        string result = req.text;
        WelcomeResponse temp = WelcomeResponse.CreateFromJSON(result);
        print(temp.message);


    }

}
