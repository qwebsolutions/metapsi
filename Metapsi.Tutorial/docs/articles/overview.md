# Welcome

This interactive tutorial covers the basics of Metapsi. The articles are sprinkled with a lot of examples wich you can load, edit & compile yourself in the side sandbox.


CodeSample:OverviewSandboxExample

Come on, go ahead. Just press the little <sl-icon name="caret-right-square"></sl-icon> button and the sample will get sent to the sandbox. Run it.
Of course, each sample can also be edited which will help you explore & understand it better.

For example, you can copy <sl-copy-button value='public string ModelProperty3 { get; set; }="Value 3";' copy-label='public string ModelProperty3 { get; set; }="Value 3"'></sl-copy-button>  this property & add it in the C# model to see how the output differs.

## The 3 sample tabs

All samples have 3 tabs. This is related to the general architecture of Metapsi which uses one-way data flow.

* The **data model** is a simple C# POCO class definition which describes ALL the data that you need to render your page or component
* The **JSON data** is the actual data to use when running the example. It must match the C# class definition
* The **view** is the code (the body of a C# function) that renders that data

<div class="rounded p-4 bg-blue-100">
Metapsi supports <strong>both server-side rendering & client side rendering</strong> as needed. Moreover you can, for example, render a server-side page containing multiple client-side nodes.
</div>

The server side rendering API is actively developed, experimental & subject to change. 
We recommend you [jump in](/tutorial/hello-world) straight to the magic (& honestly more fun) client side rendering examples to get a feel for the syntax & capabilities.