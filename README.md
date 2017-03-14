# Heos

https://usa.denon.com/us/product/hometheater/receivers/avrx6300h?docname=HEOS_CLI_PROTOCOL_Specification_290616.pdf


```cs
// create a telnet client with a list of IP addresses
var telnetClient = new SimpleTelnetClient("192.168.1.43", "192.168.1.45", "192.168.1.47");

var commandProcessor = new CommandProcessor(new HeosClient(telnetClient, CancellationToken.None));

var getPlayersResponse = await commandProcessor.Execute(new GetPlayersCommand(), r => r.Any(), 5,
   TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(2));
```

# CLI Coverage

## System Commands

| Command | Implemented |
| --- | --- |
| Register for Change Events | Yes |
| HEOS Account Check | No |
| HEOS Account Sign In | Yes |
| HEOS Account Sign Out | No |
| HEOS System Heart Beat | No |
| HEOS Speaker Reboot | No |
| Prettify JSON response | No |

## Player Commands

| Command | Implemented |
| --- | --- |
| Get Players | Yes |
| Get Player Info | Yes |
| Get Play State | Yes |
| Set Play State | Yes |
| Get Now Playing Media | Yes |
| Get Volume | Yes |
| Set Volume | Yes |
| Volume Up | Yes |
| Volume Down | Yes |
| Get Mute | Yes |
| Set Mute | Yes |
| Toggle Mute | Yes |
| Get Play Mode | Yes |
| Set Play Mode | Yes |
| Get Queue | No |
| Play Queue Item | No |
| Remove Item(s) from Queue | No |
| Save Queue as Playlist | No |
| Clear Queue | No |
| Play Next | Yes |
| Play Previous | Yes |




