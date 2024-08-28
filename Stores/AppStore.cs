namespace BlazorNavUI.Stores;

public class AppStore
{
    public Action? OnChange;

    private bool isNavOpen = false;

    public bool IsNavOpen
    {
        get { return isNavOpen; }
        set
        {
            isNavOpen = value;
            OnChange?.Invoke();
        }
    }

    public string BottomNavMenuBtnText = "Checkout";
    public string BottomNavMenuBtnActionUrl = "/checkout";
    private bool bottomNavMenuBtnVisible = false;
    public bool BottomNavMenuBtnVisible
    {
        get { return bottomNavMenuBtnVisible; }
        set 
        { 
            bottomNavMenuBtnVisible = value;
            OnChange?.Invoke();
        }
    }
    

    public void ShowBottomNavMenuBtn(string txt, string actionUrl)
    {
        BottomNavMenuBtnVisible = true;
        BottomNavMenuBtnActionUrl = actionUrl;
        BottomNavMenuBtnText = txt;

        OnChange?.Invoke();
    }
}
