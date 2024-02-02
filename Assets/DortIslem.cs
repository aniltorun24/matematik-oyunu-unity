using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DortIslem : MonoBehaviour
{
    public Text ilksayi,ikincisayi,islem,cevap,sonuc;
    public InputField sonucInput;
    int sayi1,sayi2,islemIsareti;
    int islemSonucu;
    // Start is called before the first frame update
    void Start()
    {
    yeniSoru();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cevapKontrol(){
        if(int.Parse(cevap.text)==islemSonucu)
        sonuc.text="DOĞRU";
        else{
            sonuc.text="YANLIŞ";
        }
    }
    public void yeniSoru(){
        sonuc.text = "";
        sonucInput.text = "";
       sayi1 = Random.Range(1,10);
       sayi2 = Random.Range(1,10); 
       islemIsareti = Random.Range(1,5);
       switch(islemIsareti){
        case 1:
            islem.text = "+";
            islemSonucu=sayi1+sayi2;
            break;
        case 2:
            islem.text = "-";
            islemSonucu=sayi1-sayi2;
            break;
        case 3:
            islem.text = "*";
            islemSonucu=sayi1*sayi2;
            break;
        case 4:
            islem.text = "/";
            islemSonucu=sayi1/sayi2;
            break;
        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";
       
    }
}
