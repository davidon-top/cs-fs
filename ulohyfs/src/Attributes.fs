module UlohyFs.Attributes

open System

type UlohaAttribute(id: int) =
    inherit Attribute()
    member _.Id = id
