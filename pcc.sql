SELECT [pcc].[pcc_id],[pcc].[pcc_number],[pcc].[fname],[pcc].[mname],[pcc].[lname], 
[pcc].[place_of_birth],[pcc].[date_of_birth],[pcc].[sex],[pcc].[height],[pcc].[nationality],
[pcc].[contact_no],[pcc].[ctc_number],[pcc].[ctc_issued_on],[pcc].[ctc_issued_at],
[pcc].[signature],[pcc].[img],[pcc].[thumb],[pcc].[pcc_issue_date],
[pcc].[payment_amount],[pcc].[payment_or_number],
[zone].[name] As 'zone_name',
[barangay].[name] As 'barangay_name',
[civil_status].[name] As 'cs_name',
[purpose].[name] As 'purpose_name',
police_verify.fname As 'police_vfname',
police_verify.mname As 'police_vmname',
police_verify.lname As 'police_vlname',
police_verify_rank.name As 'police_vrank',
police_verify_position.name As 'police_vposition',
police_verify.police_sig  As 'police_vsig',
police_certify.fname As 'police_cfname',
police_certify.mname As 'police_cmname',
police_certify.lname As 'police_clname',
police_certify_rank.name As 'police_crank',
police_certify_position.name As 'police_cposition',
police_certify.police_sig  As 'police_csig',
pcc.cr_id,pcc.findingsRemarks,criminal_records.crime_offense
--[findings].cr_id,[findings].specify,
--criminal_records.crime_offense
FROM [dbo].[pcc] 
INNER JOIN [police] police_verify
ON [pcc].police_id_verify = police_verify.police_id
INNER JOIN [rank] police_verify_rank
ON police_verify.rank_id = police_verify_rank.rank_id
INNER JOIN [position] police_verify_position
ON police_verify.position_id = police_verify_position.position_id
INNER JOIN [police] police_certify
ON [pcc].police_id_certify = police_certify.police_id
INNER JOIN [rank] police_certify_rank
ON police_certify.rank_id = police_certify_rank.rank_id
INNER JOIN [position] police_certify_position
ON police_certify.position_id = police_certify_position.position_id
INNER JOIN [zone]
ON [pcc].zone_id = [zone].zone_id
INNER JOIN [barangay]
ON [pcc].barangay_id = [barangay].barangay_id
INNER JOIN [civil_status]
ON [pcc].cs_id = [civil_status].cs_id
INNER JOIN [purpose]
ON [pcc].purpose_id = [purpose].purpose_id

LEFT JOIN criminal_records ON criminal_records.cr_id = pcc.cr_id

-- INNER JOIN [findings]
-- ON pcc.pcc_id = [findings].pcc_id
-- LEFT JOIN criminal_records 
-- ON criminal_records.cr_id = [findings].cr_id