# How to bind based on MappingName for GridColumn CellTemplate or EditTemplate in WPF ?
This example illustrates how to bind the CellTemplate or EditTemplate based on mapping name.

In SfDataGrid, you can load DataTemplates for columns using GridColumn.CellTemplate. The DataContext for the templates loaded inside Grid are the underlying business object corresponding to that row regardless of MappingName of the column. So it is not possible to bind the values based on the MappingName of the GridColumn for the CellTemplate or EditTemplate of GridColumn. So you have to define the template for each column, separately.

The following section describes how to bind the DataTemplate of the GridCell based on MappingName of the column.

You can achieve this requirement by setting GridColumn.SetCellBoundValue to “True” as in the following code snippet, so that the DataContext for the template is changed to DataContextHelper from underlying record of the row. DataContextHelper contains the following properties.

Value – Value of the property GridColumn.MappingName in the underlying record.

Record – Underlying record of the row where the cell is present.

So by this concept, you can use the same template for more than one column, as DataContextHelper returns the value from record based on MappingName of the column.

The following code demonstrates how to bind the Value in DataTemplate.

```XAML

<Window.Resources>
    <DataTemplate x:Key="celltemplate">
    <TextBlock Text="{Binding Path=Value}" FontWeight="Bold" Foreground="Red"/>
</DataTemplate>
</Window.Resources>
```
The following code demonstrates how to set the DataTemplate key for the CellTemplate in GridColumn.

```XAML

<syncfusion:SfDataGrid.Columns>
    <syncfusion:GridTextColumn MappingName="ProductId"/>
    <syncfusion:GridTextColumn MappingName="ProductName"/>
    <syncfusion:GridTextColumn MappingName="SalesID" SetCellBoundValue="True" CellTemplate="{StaticResource celltemplate}"/>
    <syncfusion:GridTextColumn MappingName="Percent" SetCellBoundValue="True" CellTemplate="{StaticResource celltemplate}"  />
    <syncfusion:GridTextColumn MappingName="CustomerName" />
    <syncfusion:GridTextColumn MappingName="CustomerId"/>
</syncfusion:SfDataGrid.Columns>
```
The following screenshot demonstrates the data template binding based on MappingName of the column. So, you can use the same template for different columns of SfDataGrid.

![alt text](image.png)
 



 
 