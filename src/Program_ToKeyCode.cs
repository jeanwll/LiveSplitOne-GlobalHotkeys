using GlobalHotKeys.Native.Types;

partial class Program
{
    readonly Dictionary<string, VirtualKeyCode> _toKeyCode = new()
    {
        { "A", VirtualKeyCode.KEY_A },
        { "B", VirtualKeyCode.KEY_B },
        { "C", VirtualKeyCode.KEY_C },
        { "D", VirtualKeyCode.KEY_D },
        { "E", VirtualKeyCode.KEY_E },
        { "F", VirtualKeyCode.KEY_F },
        { "G", VirtualKeyCode.KEY_G },
        { "H", VirtualKeyCode.KEY_H },
        { "I", VirtualKeyCode.KEY_I },
        { "J", VirtualKeyCode.KEY_J },
        { "K", VirtualKeyCode.KEY_K },
        { "L", VirtualKeyCode.KEY_L },
        { "M", VirtualKeyCode.KEY_M },
        { "N", VirtualKeyCode.KEY_N },
        { "O", VirtualKeyCode.KEY_O },
        { "P", VirtualKeyCode.KEY_P },
        { "Q", VirtualKeyCode.KEY_Q },
        { "R", VirtualKeyCode.KEY_R },
        { "S", VirtualKeyCode.KEY_S },
        { "T", VirtualKeyCode.KEY_T },
        { "U", VirtualKeyCode.KEY_U },
        { "V", VirtualKeyCode.KEY_V },
        { "W", VirtualKeyCode.KEY_W },
        { "X", VirtualKeyCode.KEY_X },
        { "Y", VirtualKeyCode.KEY_Y },
        { "Z", VirtualKeyCode.KEY_Z },
        { "D0", VirtualKeyCode.KEY_0 },
        { "D1", VirtualKeyCode.KEY_1 },
        { "D2", VirtualKeyCode.KEY_2 },
        { "D3", VirtualKeyCode.KEY_3 },
        { "D4", VirtualKeyCode.KEY_4 },
        { "D5", VirtualKeyCode.KEY_5 },
        { "D6", VirtualKeyCode.KEY_6 },
        { "D7", VirtualKeyCode.KEY_7 },
        { "D8", VirtualKeyCode.KEY_8 },
        { "D9", VirtualKeyCode.KEY_9 },
        { "F1", VirtualKeyCode.VK_F1 },
        { "F2", VirtualKeyCode.VK_F2 },
        { "F3", VirtualKeyCode.VK_F3 },
        { "F4", VirtualKeyCode.VK_F4 },
        { "F5", VirtualKeyCode.VK_F5 },
        { "F6", VirtualKeyCode.VK_F6 },
        { "F7", VirtualKeyCode.VK_F7 },
        { "F8", VirtualKeyCode.VK_F8 },
        { "F9", VirtualKeyCode.VK_F9 },
        { "F10", VirtualKeyCode.VK_F10 },
        { "F11", VirtualKeyCode.VK_F11 },
        { "F12", VirtualKeyCode.VK_F12 },
        { "F13", VirtualKeyCode.VK_F13 },
        { "F14", VirtualKeyCode.VK_F14 },
        { "F15", VirtualKeyCode.VK_F15 },
        { "F16", VirtualKeyCode.VK_F16 },
        { "F17", VirtualKeyCode.VK_F17 },
        { "F18", VirtualKeyCode.VK_F18 },
        { "F19", VirtualKeyCode.VK_F19 },
        { "F20", VirtualKeyCode.VK_F20 },
        { "F21", VirtualKeyCode.VK_F21 },
        { "F22", VirtualKeyCode.VK_F22 },
        { "F23", VirtualKeyCode.VK_F23 },
        { "F24", VirtualKeyCode.VK_F24 },
        { "NumPad0", VirtualKeyCode.VK_NUMPAD0 },
        { "NumPad1", VirtualKeyCode.VK_NUMPAD1 },
        { "NumPad2", VirtualKeyCode.VK_NUMPAD2 },
        { "NumPad3", VirtualKeyCode.VK_NUMPAD3 },
        { "NumPad4", VirtualKeyCode.VK_NUMPAD4 },
        { "NumPad5", VirtualKeyCode.VK_NUMPAD5 },
        { "NumPad6", VirtualKeyCode.VK_NUMPAD6 },
        { "NumPad7", VirtualKeyCode.VK_NUMPAD7 },
        { "NumPad8", VirtualKeyCode.VK_NUMPAD8 },
        { "NumPad9", VirtualKeyCode.VK_NUMPAD9 },
        { "Oem1", VirtualKeyCode.VK_OEM_1 },
        { "Oem102", VirtualKeyCode.VK_OEM_102 },
        { "Oem2", VirtualKeyCode.VK_OEM_2 },
        { "Oem3", VirtualKeyCode.VK_OEM_3 },
        { "Oem4", VirtualKeyCode.VK_OEM_4 },
        { "Oem5", VirtualKeyCode.VK_OEM_5 },
        { "Oem6", VirtualKeyCode.VK_OEM_6 },
        { "Oem7", VirtualKeyCode.VK_OEM_7 },
        { "Oem8", VirtualKeyCode.VK_OEM_8 },
        { "OemComma", VirtualKeyCode.VK_OEM_COMMA },
        { "OemMinus", VirtualKeyCode.VK_OEM_MINUS },
        { "OemPeriod", VirtualKeyCode.VK_OEM_PERIOD },
        { "OemPlus", VirtualKeyCode.VK_OEM_PLUS },
        { "Add", VirtualKeyCode.VK_ADD },
        { "Applications", VirtualKeyCode.VK_APPS },
        { "Attention", VirtualKeyCode.VK_ATTN },
        { "Backspace", VirtualKeyCode.VK_BACK },
        { "BrowserBack", VirtualKeyCode.VK_BROWSER_BACK },
        { "BrowserFavorites", VirtualKeyCode.VK_BROWSER_FAVORITES },
        { "BrowserForward", VirtualKeyCode.VK_BROWSER_FORWARD },
        { "BrowserHome", VirtualKeyCode.VK_BROWSER_HOME },
        { "BrowserRefresh", VirtualKeyCode.VK_BROWSER_REFRESH },
        { "BrowserSearch", VirtualKeyCode.VK_BROWSER_SEARCH },
        { "BrowserStop", VirtualKeyCode.VK_BROWSER_STOP },
        { "Clear", VirtualKeyCode.VK_CLEAR },
        { "CrSel", VirtualKeyCode.VK_CRSEL },
        { "Decimal", VirtualKeyCode.VK_DECIMAL },
        { "Delete", VirtualKeyCode.VK_DELETE },
        { "Divide", VirtualKeyCode.VK_DIVIDE },
        { "DownArrow", VirtualKeyCode.VK_DOWN },
        { "End", VirtualKeyCode.VK_END },
        { "EraseEndOfFile", VirtualKeyCode.VK_EREOF },
        { "Escape", VirtualKeyCode.VK_ESCAPE },
        { "Execute", VirtualKeyCode.VK_EXECUTE },
        { "ExSel", VirtualKeyCode.VK_EXSEL },
        { "Help", VirtualKeyCode.VK_HELP },
        { "Home", VirtualKeyCode.VK_HOME },
        { "Insert", VirtualKeyCode.VK_INSERT },
        { "LaunchApp1", VirtualKeyCode.VK_LAUNCH_APP1 },
        { "LaunchApp2", VirtualKeyCode.VK_LAUNCH_APP2 },
        { "LaunchMail", VirtualKeyCode.VK_LAUNCH_MAIL },
        { "LaunchMediaSelect", VirtualKeyCode.VK_LAUNCH_MEDIA_SELECT },
        { "MediaNext", VirtualKeyCode.VK_MEDIA_NEXT_TRACK },
        { "MediaPlay", VirtualKeyCode.VK_MEDIA_PLAY_PAUSE },
        { "MediaPrevious", VirtualKeyCode.VK_MEDIA_PREV_TRACK },
        { "MediaStop", VirtualKeyCode.VK_MEDIA_STOP },
        { "Multiply", VirtualKeyCode.VK_MULTIPLY },
        { "NoName", VirtualKeyCode.VK_NONAME },
        { "Pa1", VirtualKeyCode.VK_PA1 },
        { "Packet", VirtualKeyCode.VK_PACKET },
        { "PageDown", VirtualKeyCode.VK_NEXT },
        { "PageUp", VirtualKeyCode.VK_PRIOR },
        { "Pause", VirtualKeyCode.VK_PAUSE },
        { "Play", VirtualKeyCode.VK_PLAY },
        { "Print", VirtualKeyCode.VK_PRINT },
        { "Process", VirtualKeyCode.VK_PROCESSKEY },
        { "RightArrow", VirtualKeyCode.VK_RIGHT },
        { "Select", VirtualKeyCode.VK_SELECT },
        { "Separator", VirtualKeyCode.VK_SEPARATOR },
        { "Sleep", VirtualKeyCode.VK_SLEEP },
        { "Spacebar", VirtualKeyCode.VK_SPACE },
        { "Subtract", VirtualKeyCode.VK_SUBTRACT },
        { "Tab", VirtualKeyCode.VK_TAB },
        { "UpArrow", VirtualKeyCode.VK_UP },
        { "VolumeDown", VirtualKeyCode.VK_VOLUME_DOWN },
        { "VolumeMute", VirtualKeyCode.VK_VOLUME_MUTE },
        { "VolumeUp", VirtualKeyCode.VK_VOLUME_UP },
        { "Zoom", VirtualKeyCode.VK_ZOOM },
    };
}