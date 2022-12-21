using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

enum Buttons
{
    LoginButton,
}

enum Texts
{
    LoginText,
}

public class UI_Login : UI_Popup
{
    public override void Init()
    {
        Bind<Button>(typeof(Buttons));
        Bind<Text>(typeof(Texts));

        GetButton((int)Buttons.LoginButton).gameObject.BindEvent(OnButtonClicked);
        GetText((int)Texts.LoginText).gameObject.GetComponent<Text>().text = "로그인";
        
    }

    public void OnButtonClicked(PointerEventData data)
    {
        Debug.Log("로그인 시도!");

        Managers.Scene.LoadScene(Define.Scene.Game);
    }

}

