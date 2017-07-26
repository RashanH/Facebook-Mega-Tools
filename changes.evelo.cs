
private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
{
	e.DrawDefault = true;
	// let System draw this element
}

private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
{
	e.DrawDefault = true;
	// let System draw this element
}

private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
{
	// only this columnindex we take over the drawing job
	if (e.ColumnIndex == 2) {
		e.DrawBackground();
		// draw the background color
		e.DrawText();
	// other subitems, let System draw them
	} else {
		e.DrawDefault = true;
	}
}
