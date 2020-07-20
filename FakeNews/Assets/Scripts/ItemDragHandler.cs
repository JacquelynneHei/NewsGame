using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Vector3 startPosition;
    public Image backgroundImage;
    public Text headlineText;
    public Text sentenceText;
    public GameObject newsArticle;

    public GameObject[] articleAchors;
    public List<GameObject> placedArticles;

    void Start()
    {
        newsArticle = GameObject.Find("Article_1");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        gameObject.transform.parent = GameObject.Find("Application_Background").transform;
        
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(this.gameObject.transform as RectTransform, Input.mousePosition, Camera.main, out pos);



        backgroundImage.enabled = false;
        headlineText.text = "";
        sentenceText.text = "";
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.Find("Application_Background").transform as RectTransform, Input.mousePosition, Camera.main, out pos);
        transform.position = GameObject.Find("Application_Background").transform.TransformPoint(pos);
        newsArticle.transform.position = GameObject.Find("Application_Background").transform.TransformPoint(pos);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(placedArticles.Count == 0)
        {
            if (Vector2.Distance(newsArticle.transform.position, articleAchors[0].transform.position) < 5f)
            {
                newsArticle.transform.parent = GameObject.Find("Article_Container").transform;
                newsArticle.transform.position = articleAchors[0].transform.position;
                placedArticles.Add(newsArticle);
                Destroy(this.gameObject);
            }

            else
            {
                newsArticle.transform.position = new Vector3(1223, 294, 0);
                backgroundImage.enabled = true;
                headlineText.text = "This is a headline.";
                sentenceText.text = "This sentence that describes the headline";
            }
        }
        else if(placedArticles.Count == 1)
        {
            if (Vector2.Distance(newsArticle.transform.position, articleAchors[1].transform.position) < .2f)
            {
                newsArticle.transform.parent = GameObject.Find("Article_Container").transform;
                newsArticle.transform.position = articleAchors[1].transform.position;
                Destroy(this.gameObject);
            }
            else
            {
                newsArticle.transform.position = new Vector3(1223, 294, 0);
                backgroundImage.enabled = true;
                headlineText.text = "This is a headline.";
                sentenceText.text = "This sentence that describes the headline";
                
            }
        }
        else if (placedArticles.Count == 2)
        {
            if (Vector2.Distance(newsArticle.transform.position, articleAchors[2].transform.position) < .2f)
            {
                newsArticle.transform.parent = GameObject.Find("Article_Container").transform;
                newsArticle.transform.position = articleAchors[2].transform.position;
                Destroy(this.gameObject);
            }
            else
            {
                newsArticle.transform.position = new Vector3(1223, 294, 0);
                backgroundImage.enabled = true;
                headlineText.text = "This is a headline.";
                sentenceText.text = "This sentence that describes the headline";
            }
        }
        else if (placedArticles.Count == 3)
        {
            if (Vector2.Distance(newsArticle.transform.position, articleAchors[3].transform.position) < .2f)
            {
                newsArticle.transform.parent = GameObject.Find("Article_Container").transform;
                newsArticle.transform.position = articleAchors[3].transform.position;
                Destroy(this.gameObject);
            }
            else
            {
                newsArticle.transform.position = new Vector3(1223, 294, 0);
                backgroundImage.enabled = true;
                headlineText.text = "This is a headline.";
                sentenceText.text = "This sentence that describes the headline";
            }
        }

    }
}
