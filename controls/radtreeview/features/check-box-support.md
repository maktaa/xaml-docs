---
title: CheckBox Support
page_title: CheckBox Support
description: CheckBox Support
slug: check-box-support
tags: checkbox,support
published: True
position: 2
---

# CheckBox Support



Telerik __RadTreeView__ provides check boxes/radio buttons displayed next to each item. The __RadTreeView__ allows the user to check/uncheck the nodes and to perform various tasks with the collection of checked nodes. Using the corresponding events, you can entirely handle the node-check action.
	  

The purpose of this tutorial is to show you how to:

* Enable check boxes next to each item - declaratively and programmatically.
		  

* Use the "[tri-state](#Tri-state_Check_Boxes)" feature of the check boxes.
			  

* Access the check state property of the __RadTreeViewItem__ class.
			  

* Access the initially checked item when using the "[tri-state](#Tri-state_Check_Boxes)" feature of the check boxes.
			  

* Use the corresponding events to handle the check/uncheck action. 

For the next tasks will be used the treeview shown on the next figure. ![](images/RadTreeView_FeaturesCheckBoxLinesSupport_001.png)

#### __XAML__

{{region check-box-support_0}}
	<telerik:RadTreeView Margin="8" x:Name="radTreeView">
	    <telerik:RadTreeViewItem Header="Sport Categories">
	        <telerik:RadTreeViewItem Header="Football">
	            <telerik:RadTreeViewItem Header="Futsal"/>
	            <telerik:RadTreeViewItem Header="Soccer"/>
	        </telerik:RadTreeViewItem>
	        <telerik:RadTreeViewItem Header="Tennis"/>
	        <telerik:RadTreeViewItem Header="Cycling"/>
	    </telerik:RadTreeViewItem>
	</telerik:RadTreeView>
	{{endregion}}



## Enable Check Boxes Declaratively 

__RadTreeView__ provides check boxes displayed next to each item. In order to enable this behavior you need to
set the __IsOptionElementsEnabled__ property of the __RadTreeView__ to __True__.
			

For example, add the following attribute to the treeview declaration in XAML: 

#### __XAML__

{{region check-box-support_1}}
	<telerik:RadTreeView x:Name="radTreeView" IsOptionElementsEnabled="True">
	{{endregion}}



Here is a snapshot of the result. ![](images/RadTreeView_FeaturesCheckBoxLinesSupport_020.png)

## Enable Check Boxes Programmatically 

You might want to enable check boxes in the code-behind. In order to do this,
		 set the __IsOptionElementsEnabled__ property of an instance of the __RadTreeView__class to __True__.
			

#### __C#__

{{region check-box-support_2}}
	private void EnableCheckBoxes()
	{
	    radTreeView.IsOptionElementsEnabled = true;
	}
	{{endregion}}



#### __VB.NET__

{{region check-box-support_3}}
	Private Sub EnableCheckBoxes()
	    radTreeView.IsOptionElementsEnabled = True
	End Sub
	{{endregion}}



## "Tri-state" Check Boxes 

If you want your treeview to have check boxes with three states, then you need to set the __IsTriStateMode__ property of the __RadTreeView__  to __True__. When this mode is activated the __CheckState__ property of each item depends on the __CheckState__ property of its child items. In this mode the item will be checked only if all of its child items are checked too.
		

#### __XAML__

{{region check-box-support_7}}
	<telerik:RadTreeView x:Name="radTreeView" IsOptionElementsEnabled="True" IsTriStateMode="True">
	{{endregion}}



The result can be seen on the next figure: ![](images/RadTreeView_FeaturesCheckBoxLinesSupport_050.png)

The "Tri-state" behavior can be activated in the code-behind too. To do so, set the __IsTriStateMode__ property of an instance of the __RadTreeView__ class to __True__.
		

#### __C#__

{{region check-box-support_8}}
	radTreeView.IsTriStateMode = true;
	{{endregion}}



#### __VB.NET__

{{region check-box-support_9}}
	radTreeView.IsTriStateMode = True
	{{endregion}}



>importantPlease keep in mind that the __RadTreeView__ 'tri-state'
			check boxes logic is desined to work in declaratively populated
			__RadTreeView__ control. This is why if your applicaiton implements
			an MVVM approach and the __RadTreeView__ is databound, it's best to
			define custom 'tri-state' logic in your ViewModels following
			[this  tutorial]({%slug radtreeview-howto-tri-state-mvvm%}).
		  

## Accessing the CheckState Property of a RadTreeViewItem 

To see the Item check state in the code-behind you should use the __CheckState__ property of the __RadTreeViewItem__ class. The __CheckState__ property is a __ToggleState__ enumeration and has the following values:
		![](images/RadTreeView_FeaturesCheckBoxLinesSupport_060.png)

* __On__ - the treeview item is checked.
			

* __Off__ - the treeview item is not checked.
			

* __Indeterminate__ - the treeview item has items that are checked and items that are not checked. This state is available only when the __RadTreeView____IsTriStateMode__ property is set to __True__.
			

>The __ToggleState__ enumeration is a part of the __System.Windows.Automation__ namespace.
		  

## Accessing the initially checked item when using the "tri-state" check boxes 

In order to access the initially checked item when the __RadTreeView____IsTriStateMode__ property is set to __True__ you should use the __IsUserInitiated__  property of the __RadTreeViewCheckEventArgs__ class. The __IsUserInitiated__ property is a __Boolean__ property that indicates whether the item is the initially checked one.
		

#### __C#__

{{region check-box-support_10}}
	private void RadTreeViewItem_Checked(object sender, Telerik.Windows.RadRoutedEventArgs e)
	{
	 bool isInitiallyChecked = (e as RadTreeViewCheckEventArgs).IsUserInitiated;
	}
	{{endregion}}



## Events 

The __RadTreeView__ and __RadTreeViewItem__ classes____offer you four events for managing the changes of the item check state. These events are available both on the __RadTreeView__ and on the __RadTreeViewItem__ classes.
		

#### __XAML__

{{region check-box-support_12}}
	<telerik:RadTreeView Margin="8" x:Name="radTreeView" IsOptionElementsEnabled="True"
	        PreviewChecked="radTreeView_PreviewChecked"
	        Checked="radTreeView_Checked"
	        PreviewUnchecked="radTreeView_PreviewUnchecked"
	        Unchecked="radTreeView_Unchecked">
	{{endregion}}



The __PreviewChecked__ event occurs when the treeview item is about to be checked. The __Checked__ event is fired when the treeview item is already checked. The type of the passed event arguments for both of the events is __RadRoutedEventArgs__. In the event handlers you can place some code. For example, the following lines of code will set the foreground of the checked node green:
		

#### __C#__

{{region check-box-support_13}}
	private void radTreeView_Checked( object sender, RadRoutedEventArgs e )
	{
	    ( e.Source as RadTreeViewItem ).Foreground = new SolidColorBrush( Colors.Green );
	}
	{{endregion}}



#### __VB.NET__

{{region check-box-support_14}}
	Private Sub radTreeView_Checked(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
	    TryCast(e.Source, RadTreeViewItem).Foreground = New SolidColorBrush(Colors.Green)
	End Sub
	{{endregion}}



And here is the result: ![](images/RadTreeView_FeaturesCheckBoxLinesSupport_070.png)

The __PreviewUnchecked__ event is fired when the treeview item is about to be unchecked. The __Unchecked__ event occurs when the treeview item is unchecked. The type of the passed event arguments for both of the events is __RadRoutedEventArgs__.
		

>The __RadRoutedEventArgs__ class is part of the Telerik.Windows namespace.
		  

For a full list of the exposed by the __RadTreeView__ event, please refer to the [Events - Overview]({%slug radtreeview-events-overview%}) topic.
		