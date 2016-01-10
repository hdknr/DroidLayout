# pip install xmltodict
alias XJ='python -c "import xmltodict, json, sys; print json.dumps(xmltodict.parse(sys.stdin));"'
alias XY='python -c "import xmltodict, json, sys, yaml; print yaml.safe_dump(json.loads(json.dumps(xmltodict.parse(sys.stdin))),allow_unicode=True);"'

# keytools prints in SJIS
export _JAVA_OPTIONS='-Dfile.encoding=UTF-8'


alias DROID_SHELL='adb -s ${DROID_DEVICE} shell'
alias DROID_PREF='adb -s ${DROID_DEVICE} shell "run-as ${DROID_PACKAGE} cat shared_prefs/${DROID_PACKAGE}_preferences.xml"'
alias DROID_FILES='adb -s ${DROID_DEVICE} shell "run-as ${DROID_PACKAGE} ls files"'

function DROID_CAT()
{
    adb -s ${DROID_DEVICE} shell "run-as ${DROID_PACKAGE} cat files/$1"
}
