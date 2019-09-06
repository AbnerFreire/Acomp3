namespace Acomp3
{
    class HeapSort : IHeapSort
    {
        public void Heap(int[] E, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(E, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = E[0];
                E[0] = E[i];
                E[i] = temp;
                Heapify(E, i, 0);
            }
        }

        public void Heapify(int[] E, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && E[left] > E[largest])
                largest = left;
            if (right < n && E[right] > E[largest])
                largest = right;
            if (largest != i)
            {
                int swap = E[i];
                E[i] = E[largest];
                E[largest] = swap;
                Heapify(E, n, largest);
            }
        }

        public void Sort(int[] E, int n)
        {
            Heap(E, n);
        }
    }
}