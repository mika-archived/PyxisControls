# PyxisControls
Open-Source controls of Pyxis.

## Controls

In documents, below prefixes is...

| prefix       | namespace                           |
| ------------ | ----------------------------------- |
| `controls`   | `PyxisControls`                     |
| `controlsEx` | `PyxisControls.Extend`              |
| `msControls` | `Microsoft.Toolkit.Uwp.UI.Controls` |


## PyxisControls.PixivImage Control

Display pixiv image as [Image Control](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.image).


### Syntax

```xml
<msControls:AdaptiveGridView DesiredWidth="150"
                             IsItemClickEnabled="True"
                             ItemHeight="150"
                             ItemsSource="{Binding RecommendIllusts, Mode=OneWay}"
                             SelectionMode="Single">
    <msControls:AdaptiveGridView.ItemTemplate>
        <DataTemplate d:DataContext="{d:DesignInstance cvm:IllustViewModel}">
            <controlsEx:PixivImageEx Source="{Binding ThumbnailUrl, Mode=OneWay}"
                                     Stretch="UniformToFill" />
        </DataTemplate>
    </msControls:AdaptiveGridView.ItemTemplate>
</msControls:AdaptiveGridView>
```

### Output Image

<img src="https://user-images.githubusercontent.com/10832834/42731913-34558298-8852-11e8-9294-f79eb95e03cb.PNG" width="400" />



## PyxisControls.PixivPersonPicture

Display pixiv image as [PersonPicture Control](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.personpicture).


### Syntax

```xml
<StackPanel Padding="10"
            VerticalAlignment="Bottom"
            Orientation="Vertical">
    <StackPanel.Resources>
        <Style TargetType="TextBlock">
            <Setter Property="Foreground" Value="{ThemeResource ApplicationPageBackgroundThemeBrush}" />
        </Style>
    </StackPanel.Resources>
    <TextBlock FontSize="18"
               FontWeight="Bold"
               Text="{Binding Title}"
               TextTrimming="CharacterEllipsis"
               TextWrapping="NoWrap" />
    <StackPanel Height="32"
                Orientation="Horizontal">
        <controls:PixivPersonPicture Width="24"
                                     Height="24"
                                     VerticalAlignment="Center"
                                     Source="{Binding UserIcon}" />
        <TextBlock Margin="5,0,0,0"
                   VerticalAlignment="Center"
                   HorizontalTextAlignment="Center"
                   Text="{Binding Username}"
                   TextTrimming="CharacterEllipsis"
                   TextWrapping="NoWrap" />
    </StackPanel>
</StackPanel>
```


### Output Image

<img src="https://user-images.githubusercontent.com/10832834/42731982-32fc153c-8853-11e8-8044-3b1737243a52.PNG" width="200" />



## PyxisControls.Extend.ImageEx

Pixiv supports of ImageEx in Windows Community Toolkit.


### Syntax

```xml
<msControls:AdaptiveGridView DesiredWidth="150"
                             IsItemClickEnabled="True"
                             ItemHeight="150"
                             ItemsSource="{Binding RecommendIllusts, Mode=OneWay}"
                             SelectionMode="Single">
    <msControls:AdaptiveGridView.ItemTemplate>
        <DataTemplate d:DataContext="{d:DesignInstance cvm:IllustViewModel}">
            <controlsEx:PixivImageEx Source="{Binding ThumbnailUrl, Mode=OneWay}"
                                     Stretch="UniformToFill" />
        </DataTemplate>
    </msControls:AdaptiveGridView.ItemTemplate>
</msControls:AdaptiveGridView>
```

### Output Image

<img src="https://user-images.githubusercontent.com/10832834/42732009-b263bf3c-8853-11e8-9f51-3d5918eca096.gif" width="250" />