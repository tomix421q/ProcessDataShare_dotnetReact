import { useEffect, useState } from 'react'
// import { compareAsc, format } from 'date-fns'
import { FaCircle } from 'react-icons/fa'
import { Link } from 'react-router-dom'

// eslint-disable-next-line react/prop-types
const ConnectionCard = ({ name, ip, connection, route }) => {
  const [colorDot, setColorDot] = useState('text-orange-500')

  //   const date = new Date()
  //   const dateString = date.toLocaleDateString()

  //   const dayNumber = date.getDay()
  //   const dayNames = ['nedeľa', 'pondelok', 'utorok', 'streda', 'štvrtok', 'piatok', 'sobota']
  //   const dayName = dayNames[dayNumber]

  useEffect(() => {
    if (connection === 'Connection OK') {
      setColorDot('text-green-500')
    } else if (!connection) {
      setColorDot('text-orange-500')
    } else {
      setColorDot('text-red-500')
    }
  }, [connection])

  return (
    <Link to={route} className='hover:ring-4 rounded-lg  duration-100 ease-linear w-auto h-auto hover:mix-blend-hard-light'>
      <div className={`flex flex-col items-center rounded-lg border p-6 border-collor1 shadow-2xl shadow-black w-[21.875rem]`}>
        <h2 className='text-lg md:text-3xl text-secondary font-semibold flex mb-4'>
          {name}
          <span className='ml-4 my-auto'>
            <FaCircle size={20} className={`${colorDot} animate-pulse`} />
          </span>
        </h2>
        <div className='text-2xl font-semibold'>
          <h4 className='text-collor2'>
            IP : <span className='text-primary font-normal'>{ip}</span>
          </h4>

          <h4 className='text-collor2'>
            Status : <span className='text-primary font-normal text-base align-middle'>{connection}</span>
          </h4>
        </div>
      </div>
    </Link>
  )
}
export default ConnectionCard
