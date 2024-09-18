public ref struct BigNumber
{
    public Span<int> Container = new int[100_000];
    public Span<int> Numbers = new Span<int>();
    private int _size = 0;

    public BigNumber(Span<int> number)
    {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        Numbers = numbers;

        for (int i = 0; i < number.Length; i++)
        {
            Container[i] = number[i];
        }

        _size = number.Length;
    }

    public bool IsStartingPandigital()
    {
        if (_size < 9)
        {
            return false;
        }

        var numbers = Container[(_size - 9)..(_size)];

        var result = true;
        foreach (var number in Numbers)
        {
            if (Count(number, numbers) != 1)
            {
                result = false;
            }
        }

        return result;
    }

    private int Count(int n, Span<int> numbers)
    {
        var count = 0;
        foreach (var number in numbers)
        {
            if (number == n)
            {
                count++;
            }
        }

        return count;
    }

    public bool IsEndingPandigital()
    {
        if (_size < 9)
        {
            return false;
        }

        var numbers = Container[0..9];
        var result = true;
        foreach (var number in Numbers)
        {
            if (Count(number, numbers) != 1)
            {
                result = false;
            }
        }

        return result;
    }

    public void AddToContainer(Span<int> b)
    {
        var remain = 0;
        for (var index = 0; index < _size; index++)
        {
            var sum = Container[index] + b[index] + remain;
            remain = 0;
            if (sum > 9)
            {
                remain = sum / 10;
                Container[index] = sum % 10;
            }
            else
            {
                Container[index] = sum;
            }
        }

        if (remain > 0)
        {
            Container[_size] = remain;
            _size += 1;
        }
    }
}