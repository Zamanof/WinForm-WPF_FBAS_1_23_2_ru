using WF_WPF_12._MVP_Sample__interface_.Models.Interfaces;

namespace WF_WPF_12._MVP_Sample__interface_.Presenters;

internal class Presenter
{
    IModel _model;
    Form1 _view;

    public Presenter(IModel model, Form1 view)
    {
        _model = model;
        _view = view;
        _view.SomeEvent += view_SomeMethod;
    }

    private void view_SomeMethod(object? sender, EventArgs e)
    {
        _view.myTextBox.Text = _model.TextHandler(_view.myTextBox.Text);
    }
}
