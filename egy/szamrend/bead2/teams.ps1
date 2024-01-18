param (
    [string]$option,
    [string]$searchTerm
)

switch ($option) {
    "-lista" {
        Get-Content teams.dat | ForEach-Object { ($_ -split ',')[0,2] -join ',' } | Select-String $searchTerm | ForEach-Object { ($_ -split ',')[0] }
    }
    "-hallgato" {
        $codes = Get-Content ./hallgato.dat | Select-String $searchTerm | ForEach-Object { ($_ -split ',')[2..($_.Length)] }
        Get-Content ./teams.dat |  Select-String $codes | ForEach-Object { ($_ -split ',')[2].Trim() } | Format-List 

    }
    "-sok" {
        Get-Content teams.dat | ForEach-Object { ($_ -split ',')[2] } | Group-Object | Select-Object Count, Name | Sort-Object Count -Descending | Select-Object Name -First 1 | ForEach-Object { ($_.Name)} | ForEach-Object { ($_.Trim())}
    }
}
