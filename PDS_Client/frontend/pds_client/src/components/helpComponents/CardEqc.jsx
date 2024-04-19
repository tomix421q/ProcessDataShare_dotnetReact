import { useEffect, useState } from 'react'
import { Link } from 'react-router-dom'

// eslint-disable-next-line react/prop-types
const CardEqc = ({ eqcName, connection, downtime, collorRibbon, route }) => {
  const [connectionError, setConnectionError] = useState('hidden')
  const [cardCollor, setCardCollor] = useState('bg-orange-400')
  // eslint-disable-next-line no-unused-vars
  const [ribbon, setRibbon] = useState(collorRibbon)

  //state
  const [loadingData, setLoadingData] = useState(false)
  const [inProduction, setInProduction] = useState(false)
  const [inActiv, setInActiv] = useState(false)
  // inactiv times
  const [hodDowntime, setHodDowntime] = useState()
  const [minDowntime, setMinDowntime] = useState()

  useEffect(() => {
    // eslint-disable-next-line react/prop-types
    if ((connection && connection.length > 20) || undefined) {
      setConnectionError('block')
      setLoadingData(false)
    } else {
      setConnectionError('hidden')
      if (downtime == 0) {
        setCardCollor('bg-green-500')
        setLoadingData(false)
        setInProduction(true)
        setInActiv(false)
      } else if (downtime > 0) {
        setCardCollor('bg-red-600')
        setLoadingData(false)
        setInProduction(false)
        setInActiv(true)
        var hodDowntime = Math.floor(downtime / 60)
        var minDowntime = downtime % 60
        setHodDowntime(hodDowntime)
        setMinDowntime(minDowntime)
      } else {
        setCardCollor('bg-yellow-500')
        setLoadingData(true)
        setInProduction(false)
        setInActiv(false)
      }
    }
  }, [setInterval(() => {}, 10000)])

  return (
    <Link className='max-sm:snap-center' to={route}>
      {/* Card */}
      <div className='w-[17.5rem] xl:w-[30rem] h-[11.25rem] xl:h-[17.5rem] overflow-hidden border border-black flex flex-col rounded-2xl shadow-lg shadow-black font-semibold hover:shadow-collor1 drop-shadow-sm transition-all duration-200 hover:scale-105 hover:ring-4'>
        {/* NAME MACHINE */}
        <h2 className='mx-auto text-2xl xl:text-5xl uppercase text-primary font-medium w-full text-center border-b border-gray-600 py-2 font-extraFont bg-gray-700'>
          {/* ribbon  */}
          <span className={`absolute w-[6px] xl:w-[12px] h-full left-0 top-0 rounded-br-2xl ${ribbon}`}></span>
          {eqcName}
        </h2>
        <div className={`flex flex-col items-center h-full relative ${cardCollor}`}>
          {/* ERROR CARD  */}
          <div
            className={`absolute w-full h-full bg-gray-800 flex flex-col items-center mx-auto justify-center ${connectionError}`}
          >
            <h2 className='text-red-500 px-4 p-1 uppercase text-xl xl:text-4xl'>Connection Error</h2>
            <br />
            <abbr title={connection} className='cursor-help bg-red-500 px-4 p-1 uppercase text-sm xl:text-3xl no-underline'>
              Check Error
            </abbr>
          </div>
          {/* production and inactiv card and loading  */}
          <span className='text-base xl:text-2xl w-full text-center py-2'>Status</span>
          {/*  */}
          {/* LOADING  */}
          <div className={`bg-black flex p-1 py-2 px-4 items-center justify-center ${loadingData ? 'block' : 'hidden'}`}>
            <h2 className='text-xl xl:text-4xl  tracking-widest uppercase'>
              Trying to <br /> connect...
            </h2>
            <img src='/loading.svg' alt='loading' className='size-10 ml-4' />
          </div>
          {/* INPRODUCTION  */}
          <h2
            className={`bg-black px-4 p-1 mt-4 xl:mt-10 text-xl xl:text-5xl tracking-widest uppercase ${
              inProduction ? 'block' : 'hidden'
            }`}
          >
            InProduction
          </h2>
          {/* INACTIV  */}
          <div
            className={`bg-black px-4 text-md text-center flex flex-col justify-center mt-1 tracking-widest uppercase ${
              inActiv ? 'block' : 'hidden'
            }`}
          >
            <h2 className='text-gray-400'>
              <span className={`text-2xl xl:text-5xl text-primary ${hodDowntime == 0 ? 'hidden' : 'inline-block'}`}>
                {hodDowntime}
                <span className='text-gray-400 text-base xl:text-3xl'>hod</span>
              </span>
              <span className='text-2xl xl:text-5xl text-primary'>
                {' '}
                {minDowntime}
                <span className='text-gray-400 text-base xl:text-3xl'>min</span>
              </span>
            </h2>
            <h2 className='text-2xl xl:text-5xl'>Inactive</h2>
          </div>
        </div>
      </div>
    </Link>
  )
}
export default CardEqc
