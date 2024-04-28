using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Documents;

namespace WF_WPF_10._Collection_Notify;

internal class DataSource
{
    private ICollection<int> _notNotifyCollection = new List<int> { 1, 2, 3 };
    public ICollection<int> NotNotifyCollection => _notNotifyCollection;
    
    
    private ICollection<int> _notifyCollection = new ObservableCollection<int> {1, 2, 3};
    public ICollection<int> NotifyCollection => _notifyCollection;

    public void AddValueToNotNotify()
    {
        NotNotifyCollection.Add(NotNotifyCollection.Count + 1);
    }
    
    public void AddValueToNotify()
    {
        NotifyCollection.Add(NotifyCollection.Count + 1);
    }
}
