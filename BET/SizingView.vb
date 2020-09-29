'------------------------------------------------- CABEÇALHO -------------------------------------------------------------        
'Nome do programa		    : ECCUSBet;
'Versão                     : 1.0;
'Objetivo                   : Software para dimensionar bacia de evapotranspiração;
'Empresa Responsável		: ONG Instituto ECCUS;
'Criado em                  : 11/09/2020.
'-------------------------------------------------------------------------------------------------------------------------   
'Histórico de atividades        
'Autor                   Data       Descrição        
'----------------------  ---------- --------------------------------------------------------------------------------------        
'Austregíselo Junior     11/09/2020 Criação do APP e Início do layout;
'Austregíselo Junior     12/09/2020 desenvolvimento do layout;
'Austregíselo Junior     14/09/2020 Desenvolvimento do layout e início das implementaçôes das views e regras de negócio;
'Austregíselo Junior     15/09/2020 Implementação das regras de negócio e desenvolvimento de layout;
'Austregíselo Junior     16/09/2020 Implementação dos cálculos completa e funcionando;
'Austregíselo Junior     17/09/2020 Adicionando a programaçõpa defensiva em caso de erro na adição de dado de entrada;
'Austregíselo Junior     18/09/2020 Adicionando a programaçõpa defensiva em caso de erro na adição de dado de entrada;
'Austregíselo Junior     21/09/2020 Exportando dados do Grid para excel e fim do APP
'-------------------------------------------------------------------------------------------------------------------------
'Histórico de Bugs        
'Autor                   Data Descrição  
'----------------------  ---------- --------------------------------------------------------------------------------
'Austregíselo Junior     15/09/2020 O Volume útil está dando valor errado, os valores das funçõa estão dando igual a 0;
'                                   Resolução -> A contribuição deve retornar apenas Rc;
'Austregíselo Junior     16/09/2020 As funções PeriododeDetencao() e TaxadeAcumulacao() não estão reconhecendo os parâmetros;
'                                   Resolução -> No PeriodoDetencao() coloquei o CDiarioTotal dentro da função PeriodoDetencao(). 
'                                   Já a função TaxadeAcumulacao estava faltando o ".tex" ao final da expressão.
'-------------------------------------------------------------------------------------------------------------------------
Imports Microsoft.Office.Interop.Excel
Public Class SizingView
    Dim VolUtio, AreadaBet, NPessoa, CDiarioTotal As Double
    ReadOnly CLodoFresco As Integer = 1
    ReadOnly MetroQuadradoporHab As Integer = 2
    Dim Rc, Rp, Rt As Integer
    Private Function ContribuicaoDiaria() As Integer
        If SelecaoPadrao.SelectedItem = "Residência padrão baixo" Then
            Rc = 100
        ElseIf SelecaoPadrao.SelectedItem = "Residência padrão médio" Then
            Rc = 130
        ElseIf SelecaoPadrao.SelectedItem = "Residência padrão alto" Then
            Rc = 160
        ElseIf SelecaoPadrao.SelectedItem = "Hotel" Then
            Rc = 100
        ElseIf SelecaoPadrao.SelectedItem = "Alojamento provisório" Then
            Rc = 80
        Else
            MsgBox("Erro, escolha um ítem!")
        End If
        Return Rc
    End Function
    Private Function PeriododeDetencao() As Integer
        CDiarioTotal = (Rc * NPessoa)

        If TxtNPessoas.Text = "" Then
            Rp = 0
            MsgBox("Erro, adicione o número de pessoas!")
        End If

        If CDiarioTotal <= 1500 Then
            Rp = 1
        ElseIf CDiarioTotal >= 1501 And CDiarioTotal <= 3000 Then
            Rp = 0.92
        ElseIf CDiarioTotal >= 3001 And CDiarioTotal <= 4500 Then
            Rp = 0.83
        ElseIf CDiarioTotal >= 4501 And CDiarioTotal <= 6000 Then
            Rp = 0.75
        ElseIf CDiarioTotal >= 6001 And CDiarioTotal <= 7500 Then
            Rp = 0.67
        ElseIf CDiarioTotal >= 7501 And CDiarioTotal <= 9000 Then
            Rp = 0.58
        Else
            Rp = 0.5
        End If
        Return Rp
    End Function
    Public Function TaxadeAcumulacao(ByVal intervalo As Integer, ByVal temperatura As Integer) As Integer
        If TxtIntervalo.Text = "" Then
            Rt = 0
            MsgBox("Erro, adicione o tempo para limpeza!")
        ElseIf TxtTemperatura.Text = "" Then
            Rt = 0
            MsgBox("Erro, adicione a temperatura!")
        End If

        If intervalo = 1 Then
            For index = 0 To 3
                If temperatura <= 10 Then
                    Rt = 94
                ElseIf temperatura >= 10 And temperatura <= 20 Then
                    Rt = 65
                Else
                    Rt = 57
                End If
            Next
        ElseIf intervalo = 2 Then
            For index = 0 To 3
                If temperatura <= 10 Then
                    Rt = 134
                ElseIf temperatura >= 10 And temperatura <= 20 Then
                    Rt = 105
                Else
                    Rt = 97
                End If
            Next
        ElseIf intervalo = 3 Then
            For index = 0 To 3
                If temperatura <= 10 Then
                    Rt = 174
                ElseIf temperatura >= 10 And temperatura <= 20 Then
                    Rt = 145
                Else
                    Rt = 137
                End If
            Next
        ElseIf intervalo = 4 Then
            For index = 0 To 3
                If temperatura <= 10 Then
                    Rt = 214
                ElseIf temperatura >= 10 And temperatura <= 20 Then
                    Rt = 185
                Else
                    Rt = 177
                End If
            Next
        ElseIf intervalo = 5 Then
            For index = 0 To 3
                If temperatura <= 10 Then
                    Rt = 254
                ElseIf temperatura >= 10 And temperatura <= 20 Then
                    Rt = 225
                Else
                    Rt = 217
                End If
            Next
        End If
        Return Rt
    End Function

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Manual.Close()
        Dev.Close()
        Me.Close()
    End Sub

    Private Sub LimparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparToolStripMenuItem.Click
        TxtTemperatura.Clear()
        TxtIntervalo.Clear()
        TxtNPessoas.Clear()
        TxtVolUtio.Clear()
        TxtProfundidadeMedia.Clear()
        TxtAreadaBet.Clear()
        TxtVoldaBet.Clear()
        SelecaoPadrao.Text = ""
    End Sub

    Private Sub DesenvolvedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesenvolvedorToolStripMenuItem.Click
        Dev.Show()
    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        Manual.Show()
    End Sub

    Private Sub SizingView_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Manual.Close()
        Dev.Close()
    End Sub
    Private Function ProfundidadeUtil()
        Dim PMIni, PMax, PMedio As Double
        If TxtVolUtio.Text = 0 Then
            TxtProfundidadeMedia.Text = 0
        End If

        If VolUtio <= 6 Then
            PMIni = 1.2
            PMax = 2.2
            PMedio = ((PMIni + PMax) / 2)
        ElseIf VolUtio >= 6 And VolUtio <= 10 Then
            PMIni = 1.5
            PMax = 2.5
            PMedio = ((PMIni + PMax) / 2)
        ElseIf VolUtio > 10 Then
            PMIni = 1.8
            PMax = 2.8
            PMedio = ((PMIni + PMax) / 2)
        End If
        Return PMedio
    End Function
    Private Sub BtnDimensionat_Click(sender As Object, e As EventArgs) Handles BtnDimensionat.Click
        Dim CD, PD, TA As Double
        NPessoa = Val(TxtNPessoas.Text)
        CD = Val(ContribuicaoDiaria())
        PD = Val(PeriododeDetencao())
        TA = Val(TaxadeAcumulacao(intervalo:=Val(TxtIntervalo.Text), temperatura:=Val(TxtTemperatura.Text)))

        VolUtio = (1000 + NPessoa * ((CD * PD) + (TA * CLodoFresco))) / 1000
        TxtVolUtio.Text = VolUtio

        If CD = 0 Or PD = 0 Or TA = 0 Then
            TxtVolUtio.Text = 0
        End If

        TxtProfundidadeMedia.Text = ProfundidadeUtil()
        AreadaBet = (NPessoa * MetroQuadradoporHab)
        TxtAreadaBet.Text = AreadaBet
        TxtVoldaBet.Text = (AreadaBet * ProfundidadeUtil())

        Me.DataGridView1.Rows.Add(TxtVolUtio.Text, TxtProfundidadeMedia.Text, TxtAreadaBet.Text, TxtVoldaBet.Text)
    End Sub
    Private Sub BtnAnalise_Click(sender As Object, e As EventArgs) Handles BtnAnalise.Click
        '//////////////////////////////// Definir o tipo de gráfico //////////////////////////
        Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Spline

        '///////// Não deixa o gráfico ficar repetido, ele vai até o número de colunas/////////
        Chart1.Series(0).Points.Clear()

        '////////// Defini a coluna do grid e seleciona o número de linhas que o gráfico ler //////
        For LinhadoGrid As Integer = 0 To DataGridView1.Rows.Count - 1
            '//////////////////////////////////// Adiciona valores do DataGrid ao gráfico,a coluna 2 = x do gráfico e a coluna 1 = y dp gráfico ///////////////////
            Chart1.Series(0).Points.AddXY(DataGridView1.Item(3, LinhadoGrid).Value, DataGridView1.Item(0, LinhadoGrid).Value)
        Next
    End Sub
    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim ExcelAPP As New Application 'Instanciando o Aplicativo 
        ExcelAPP.Visible = True 'Tornanbdo o aplicativo visível 

        Dim Workbook1 As Workbook 'Instanciando a coleção de planilhas, tipo um livro
        Workbook1 = ExcelAPP.Workbooks.Add() ' Adicionando uma a coleção "livro"

        Dim WorkSheet As Worksheet 'Instanciando a planilha
        WorkSheet = Workbook1.Worksheets.Add() 'Adicionando uma planilha
        WorkSheet.Name = "Dimensionamento Bet" ' Alterando o nome da planilha

        ' //////////////////// EXportar os títulos das colunas /////////////////////
        Try
            For C As Integer = 1 To DataGridView1.Columns.Count
                WorkSheet.Cells(1, C) = DataGridView1.Columns(C - 1).HeaderText
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Dim C As Integer = DataGridView1.Columns.Count
            WorkSheet.Cells(1, C) = DataGridView1.Columns(C - 1).HeaderText
        End Try

        '///////////////// Exportando linhas e colunas///////////////////////
        For L As Integer = 0 To DataGridView1.Rows.Count - 1
            For C As Integer = 0 To DataGridView1.Columns.Count - 1
                WorkSheet.Cells(L + 2, C + 1) = DataGridView1.Rows(L).Cells(C).Value.ToString()
            Next
        Next

        '///// Passando a Vassoura, para quando abrir o PC novamente não ter planilha aberta ///////
        Limpeza(ExcelAPP)
        Limpeza(Workbook1)
        Limpeza(WorkSheet)
    End Sub
    Private Sub Limpeza(ByRef obj As Object)
        Runtime.InteropServices.Marshal.ReleaseComObject(obj)
        obj = Nothing
        GC.Collect()
    End Sub


End Class