<div class="horizontal paragraph">
		<script src="https://emgithub.com/embed-v2.js?target=https%3A%2F%2Fgithub.com%2FHuntersonStudio%2FExamples%2Fblob%2Fmain%2FEditorWindowTipTest.cs%23L7-L18&style=github-dark-dimmed&type=code"></script>
		<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse elementum facilisis placerat. Fusce auctor elit erat, in pharetra est vehicula eget. Nam arcu nunc, feugiat eget imperdiet in, facilisis eu ligula. Aliquam vel auctor tortor. Vivamus nunc erat, tristique at dolor eget, sodales feugiat augue. Mauris vel sem in sem egestas luctus ut eget eros. Curabitur quis eleifend turpis. Donec euismod, sapien a sagittis accumsan, sapien augue sagittis sapien, id sollicitudin orci libero sit amet purus. Suspendisse potenti. Mauris scelerisque magna ante, dictum cursus nisi eleifend non.</p>
	</div>
#end

public unsafe void Add(int _int, int _index = -1)
{
    int index = _index <= -1 ? tracker : _index;

    EnsureSize(4, index);

    fixed (void* ptr = &_buffer[index])
        *((int*)ptr) = _int;

    if (_index <= -1)
        tracker += 4;
}
