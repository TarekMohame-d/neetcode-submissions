public class MinStack {
    private List<int> values = new();
    private List<int> mins = new();

    public MinStack() {}

    public void Push(int val) {
        values.Add(val);

        if (mins.Count == 0)
            mins.Add(val);
        else
            mins.Add(Math.Min(val, mins[^1]));
    }

    public void Pop() {
        values.RemoveAt(values.Count - 1);
        mins.RemoveAt(mins.Count - 1);
    }

    public int Top() {
        return values[^1];
    }

    public int GetMin() {
        return mins[^1];
    }
}
