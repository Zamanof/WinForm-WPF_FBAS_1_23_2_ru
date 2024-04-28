using WF_WPF_12._MVP_Sample;

internal class Presenter
{
    Model _model;
    Form1 _view;

    public Presenter(Form1 view)
    {
        _view = view;
        _model = new Model();
        _view.SomeEvent += view_SomeMethod;
    }

    private void view_SomeMethod(object? sender, EventArgs e)
    {
        _view.myTextBox.Text = _model.HandleText(_view.myTextBox.Text);
    }
}
