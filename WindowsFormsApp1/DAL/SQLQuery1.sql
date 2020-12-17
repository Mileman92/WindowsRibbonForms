declare
   @intPrmAnlage int, @GreatPlant int;

select *
from (
	select distinct
		 @intPrmAnlage as intCsIDGP
		,null as intCsIdxBetrieb
		,null as strCsBetriebsteil
		,null as strCsCde
		,null as intCsIdxGebaeude
		,null as strCsGebaeude
		,null as intCsIdxEtage
		,null as strCsEtage
		,0 as intCsIdGrp
		,'OG' as strCsGrp
		,0 as intCsIda
		,-1 as intCsIdRef
		,0 as intCsLevel
		,'0000000000' as strCsPath
		,'Prüfobjekte' as strCsObjects
		,null as intCsErwAppNr
		,null as intCsIdAppStatus
		,null as strCsKennung
		,null as strCsAppStatus
		,null as strCsAescWertInnen
		,null as strCsAescWertAußen
		,null as blnCsAescIstExSchutzZone
		,null as intCsIdObj
		,null as intCsIdn
		,'Prüfobjekte' as strCsDescript
		,null as strCsObjekt
		,null as strCsUnterobjekt
		,null as strCsUnterobjekt2
		,null as strCsAnweisung
		,null as intCsIdRb
		,null as intCsHasRules
		,null as strCsRulePIV
		,null as strCsRulePRIO
		,null as strCsRuleBZ
		,null as strCsRulePV
		,null as strCsRulePD
		,null as strCsRulePO
		,null as strCsRuleMC
		,null as strCsRuleDAO
		,null as strCsRuleGP
		,null as strCsRuleSU
		,null as strCsRuleSH
		,null as StrCsRuleRM
		,null as strCsRuleMIN
		,null as datCsRuleAK
		,null as datCsRuleDK
		,null as strCsRuleEIE
		,null as strCsUser
		,cast(10 as varchar(2)) + '|' + 'Prüfobjekte' as strCsSortKey

	union all

	select distinct
		 c.IDGP as intCsIDGP
		,c.IdxBetrieb as intCsIdxBetrieb
		,c.Betriebsteil as strCsBetriebsteil
		,b.CDE as strCsCde
		,c.IdxGebaeude as intCsIdxGebaeude
		,c.Gebaeude as strCsGebaeude
		,c.IdxEtage as intCsIdxEtage
		,c.Etage as strCsEtage
		,c.IDGrp as intCsIdGrp
		,c.Grp as strCsGrp
		,c.IDA as intCsIda
		,c.IDRef as intCsIdRef
		,c.[Level] as intCsLevel
		,c.[Path] as strCsPath
		,c.[Objects] as strCsObjects
		,c.erwAppNr as intCsErwAppNr
		,c.IDAppStatus as intCsIdAppStatus
		,isNull(cast(a.[Alkylose-Kennung] as varchar(250)) + ' - Kennung', case when c.IDGrp > 1 then ' ' + left(c.[Objects], charIndex(' » ' + c.Objekt, c.[Objects])) else null end) as strCsKennung
		,s.[Status] as strCsAppStatus
		,aesz_i.strAescWert as strCsAescWertInnen
		,aesz_a.strAescWert as strCsAescWertAußen
		,case
			when c.IDGrp > 1
			then case
					when  (isNull(aesz_a.blnAescIstExSchutzZone, 0) != 0 or isNull(aesz_i.blnAescIstExSchutzZone, 0) != 0) and not (aesz_a.strAescWert = 'keine' and aesz_i.strAescWert = 'keine')
					then 1
					else 0
				end
			else null
		 end as blnCsAescIstExSchutzZone
		,c.IDObj as intCsIdObj
		,c.IDN as intCsIdn
		,c.Descript as strCsDescript
		,c.Objekt as strCsObjekt
		,c.Unterobjekt as strCsUnterobjekt
		,replicate(' ', (c.[level]-2)*2) + c.Descript as strCsUnterobjekt2
		,c.Anweisung as strCsAnweisung
		,c5.IDRB as intCsIdRb
		,case
			when c.IdGrp = 4
			then case
				when isNull(c5.IDRB, 0) = 0
				then 0
				else 1
			end
			else null
		end as intCsHasRules
		,c5.PIV as strCsRulePIV
		,c5.PRIO as strCsRulePRIO
		,c5.BZ as strCsRuleBZ
		,c5.PV as strCsRulePV
		,c5.PD as strCsRulePD
		,c5.PO as strCsRulePO
		,c5.MC as strCsRuleMC
		,c5.DAO as strCsRuleDAO
		,c5.GP as strCsRuleGP
		,c5.SU as strCsRuleSU
		,c5.SH as strCsRuleSH
		,c5.RM as StrCsRuleRM
		,c5.[MIN] as strCsRuleMIN
		,c5.AK as datCsRuleAK
		,c5.DK as datCsRuleDK
		,c5.EIE as strCsRuleEIE
		,case when c5.IDA is not null then c.[User] else null end as strCsUser
		,cast(10-c.IdGrp as varchar(2)) + '|' + c.Descript as strCsSortKey
	from tf_GetCommonStruct(@intPrmAnlage, null) c
		left join tf_GetCommonExtended(@intPrmAnlage) c5 on c.IDA = c5.IDRef
		left join App a on c.erwAppNr = a.erwAppNr
		left join AESZ aesz_a on aesz_a.pkAescID = a.fkExSchutzAußen
		left join AESZ aesz_i on aesz_i.pkAescID = a.fkExSchutzInnen
		left join tblAppStatus s on a.IDAppStatus = s.IDAppStatus
		left join tblBetrieb b on b.IdxBetrieb = a.IdxBetrieb
	where c.IDGrp < 5
) q
order by q.intCsIdRef, q.intCsIda