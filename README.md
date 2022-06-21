# kfWrapper V2.0

A ROBLOX API Wrapper. Doesn't support POST requests because ROBLOX'S API is too annoying to work with.

# Group Documentation

```txt

Setup: Groups.FromID("id");

Available Options: Groups.GetInfo("Name") // "Name", "Description", "Owner", "Created"

```
# Group game Documentation

```txt

Setup: Games.FromGroup("id");

Available Options: Games.GroupGameInfo("Name") // "Name", "Description", "Owner", "Created", "Updated", "Visits" // prob some other check the roblox api for more

```
# Asset documentation

```txt

Setup: Assets.FromID("ID")

Available Options: Assets.GetInfo("Name") // "Name", "Description", "CreatorName", "CreatorId" // check the roblox api docs for more, there's more options there
```
# User details documentation

```txt

Setup: UserDetails.SetID("ID")

Available Options: UserDetails.GetInfo("Name") // "Name", "Description", "DisplayName", "IsBanned", "Created"
```