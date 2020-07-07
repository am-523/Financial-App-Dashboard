
Imports System.Windows.Media
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Public Class Form1
    Private Sub DoughChart()

        PieChart1.InnerRadius = 70
        PieChart1.LegendLocation = LegendLocation.Right
        PieChart1.Series = New SeriesCollection From {
            New PieSeries With {
                .Title = "Ebay",
                .Values = New ChartValues(Of Double) From {
                    8
                },
                .PushOut = 15,
                .DataLabels = True
            },
            New PieSeries With {
                .Title = "Amazon",
                .Values = New ChartValues(Of Double) From {
                    6
                },
                .DataLabels = True
            },
            New PieSeries With {
                .Title = "Mcdonalds",
                .Values = New ChartValues(Of Double) From {
                    10
                },
                .DataLabels = True
            },
            New PieSeries With {
                .Title = "PS Store",
                .Values = New ChartValues(Of Double) From {
                    4
                },
                .DataLabels = True
            }
        }

    End Sub
    Private Sub chartcolum()
        CartesianChart1.Series = New SeriesCollection From {
                New ColumnSeries With {
                    .Title = "2015",
                    .Values = New ChartValues(Of Double) From {
                        10,
                        50,
                        39,
                        50,
                        40,
                        60,
                        10,
                        35,
                        70,
                        40,
                        60,
                        10,
                        35
                    }
                }
            }
        CartesianChart1.Series.Add(New ColumnSeries With {
            .Title = "2020",
            .Values = New ChartValues(Of Double) From {
                11,
                56,
                42,
                  40,
                        60,
                        10,
                        35,
                        70,
                        40,
                        60,
                        10,
                        35
            }
        })
        CartesianChart1.Series(1).Values.Add(48.0R)
        CartesianChart1.AxisX.Add(New Axis With {
            .Title = "Payments",
            .Labels = {"Jan", "Feb", "Mar", "Apr", "Mey", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"}
        })
        CartesianChart1.AxisY.Add(New Axis With {
            .Title = "Currency",
            .LabelFormatter = Function(value) value.ToString("N")
        })
    End Sub

    Private Sub list()
        Guna2DataGridView1.Rows.Add(4)
        Guna2DataGridView1.Rows(0).Cells(0).Value = "$140.50"
        Guna2DataGridView1.Rows(0).Cells(1).Value = "$435.92"
        Guna2DataGridView1.Rows(0).Cells(2).Value = "$789.11"
        Guna2DataGridView1.Rows(0).Cells(3).Value = "$14890.67"

        Guna2DataGridView1.Rows(1).Cells(0).Value = "$140.50"
        Guna2DataGridView1.Rows(1).Cells(1).Value = "$435.92"
        Guna2DataGridView1.Rows(1).Cells(2).Value = "$789.11"
        Guna2DataGridView1.Rows(1).Cells(3).Value = "$14890.67"

        Guna2DataGridView1.Rows(2).Cells(0).Value = "$140.50"
        Guna2DataGridView1.Rows(2).Cells(1).Value = "$435.92"
        Guna2DataGridView1.Rows(2).Cells(2).Value = "$789.11"
        Guna2DataGridView1.Rows(2).Cells(3).Value = "$14890.67"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoughChart()
        chartcolum()
        list()
    End Sub
End Class
