# iOSGameControllerRemote
Workaround for Apple TV Remote controller in new Unity InputSystem

Current InputSystem iOSGameController generates both left stick & DPad events simultaneously which messes input.
iOSGameControllerRemote is the Apple TV Remote controller layout with disabled DPad events.
DPad events are mapped to right stick press here (dirty hack) which are supposed as not used in the game.
If someone knows how to disable DPad with no hacky mapping write me a message please.
