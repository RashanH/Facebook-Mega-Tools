private void SetControlEnabled(Control ctl, bool enabled)
{
    if (ctl.InvokeRequired)
        ctl.BeginInvoke(new Action<Control, bool>(SetControlEnabled), ctl, enabled);
    else
        ctl.Enabled = enabled;
}


Usage : 
SetControlEnabled(someButton, False);
