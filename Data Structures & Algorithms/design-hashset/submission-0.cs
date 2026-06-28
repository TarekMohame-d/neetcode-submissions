public class MyHashSet {
    private List<int> _items;
    public MyHashSet() {
        _items = [];
    }

    public void Add(int key) {
        if (_items.Contains(key))
            return;

        _items.Add(key);
    }

    public void Remove(int key) {
        _items.Remove(key);
    }

    public bool Contains(int key) {
        return _items.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */