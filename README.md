# bug-url-query-param

when sending the following url **?=bug** every parameter will get filled with the string "bug"
(except those with the `FromQuery` attribute that has the `Name=` property specified)

![bug example ?=bug](example-bug.png)

sending **?=bug&b=test** will give all* parameters bug and the value for `b` will be `test`

![bug example ?=bug](example-bug-test.png)

sending a empty pair like **?=** results in

![bug example ?=](example-empty-kvp.png)

sending just a **?** is normal

![bug example ?](example-questionmark.png)