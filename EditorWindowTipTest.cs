#code sample1

Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse elementum facilisis placerat. Fusce auctor elit erat, in pharetra est vehicula eget. Nam arcu nunc, feugiat eget imperdiet in, facilisis eu ligula. Aliquam vel auctor tortor. Vivamus nunc erat, tristique at dolor eget, sodales feugiat augue. Mauris vel sem in sem egestas luctus ut eget eros. Curabitur quis eleifend turpis. Donec euismod, sapien a sagittis accumsan, sapien augue sagittis sapien, id sollicitudin orci libero sit amet purus. Suspendisse potenti. Mauris scelerisque magna ante, dictum cursus nisi eleifend non.
#example

#begin sample1
public unsafe void Add(int _int, int _index = -1)
{
    int index = _index <= -1 ? tracker : _index;

    EnsureSize(4, index);

    fixed (void* ptr = &_buffer[index])
        *((int*)ptr) = _int;

    if (_index <= -1)
        tracker += 4;
}
#end sample1
